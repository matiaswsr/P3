using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;
using Microsoft.Data.SqlClient;

namespace Repositorios
{
    public class RepositorioPlanta : IRepositorioPlanta
    {
        public bool Add(Planta obj)
        {
            bool ok = false;

            SqlConnection con = Conexion.ObtenerConexion();
            string sql = "INSERT INTO Plantas  VALUES (@IdTipo, @IdFicha, @NomCien, @Descrip, @Foto, @Ambiente, @AlturaMax);";
            string sqlNomVul = "INSERT INTO PlantasNombreVul VALUES (@nomVul, @idPlanta);";
            SqlCommand command = new SqlCommand(sql, con);

            TipoAmbiente amb = obj.Ambiente;
            string ambiente = amb.ToString();

            command.Parameters.AddWithValue("@IdTipo", obj.Tipo.Id );
            command.Parameters.AddWithValue("@IdFicha", obj.Ficha.Id );
            command.Parameters.AddWithValue("@NomCien", obj.NombreCientifico );
            command.Parameters.AddWithValue("@Descrip", obj.Descripcion);
            command.Parameters.AddWithValue("@Foto", obj.Foto );
            command.Parameters.AddWithValue("@Ambiente", ambiente );
            command.Parameters.AddWithValue("@AlturaMax", obj.AlturaMax);

            SqlTransaction transaction = null;

            try
            {
                Conexion.AbrirConexion(con);
                transaction = con.BeginTransaction();
                command.Transaction = transaction;
                
                int IdPlanta = (int)command.ExecuteScalar();

                foreach (string nomVul in obj.NombresVulgares)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@idPlanta", IdPlanta);
                    command.Parameters.AddWithValue("@nomVul", nomVul);
                    command.CommandText = sqlNomVul;
                    command.ExecuteNonQuery();
                }    
                                
                transaction.Commit();
                ok = true;

            }
            catch
            {
                if (transaction != null) transaction.Rollback();
                throw;
            }
            finally
            {
                Conexion.CerrarYDisposeConexion(con);
            }

            return ok;
        }

        public IEnumerable<Planta> FindAll()
        {
            List<Planta> plantas = new List<Planta>();

            SqlConnection con = Conexion.ObtenerConexion();
            string sql = "SELECT * FROM Plantas;";
            SqlCommand command = new SqlCommand(sql, con);
            
            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = command.ExecuteReader();


                // es true si hay más filas por leer, sino false
                while (reader.Read())
                {
                    Planta p = CrearPlanta(reader);
                    p.Ambiente = stringToAmbiente(reader.GetString(6));
                    p.Ficha = CrearFicha(reader.GetInt32(2));
                    p.NombresVulgares = CrearNombresVul(reader.GetInt32(0));

                    plantas.Add(p);
                }

                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return plantas;
        }

        public Planta CrearPlanta(SqlDataReader reader)
        {
            Planta p = null;

            p.Id = reader.GetInt32(0);
            p.NombreCientifico = reader.GetString(3);
            p.Descripcion = reader.GetString(4);
            p.Foto = reader.GetString(5);
            p.AlturaMax = reader.GetDecimal(7);

            return p;
        }

        public List<String> CrearNombresVul (int id)
        {
            List<String> nombresVul = null;

            SqlConnection con = Conexion.ObtenerConexion();
            string sql = "SELECT NombreVulgar FROM PlantaNombreVul WHERE IdPlanta =" + id + ";";
            SqlCommand command = new SqlCommand(sql, con);

            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                   nombresVul.Add(reader.GetString(0));
                }

                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return nombresVul;
        }

        public FichaCuidados CrearFicha(int idFicha)
        {

            FichaCuidados ficha = null;

            SqlConnection con = Conexion.ObtenerConexion();
            string sql = "SELECT * FROM FichaCuidados WHERE Id =" + idFicha + ";";
            SqlCommand command = new SqlCommand(sql, con);

            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = command.ExecuteReader();

                ficha.Id = reader.GetInt32(0);
                ficha.Temperatura = reader.GetDecimal(1);
                ficha.FrecuenciaRiego = reader.GetString(2);
                ficha.TipoIluminacion = reader.GetString(3);                

                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return ficha;

        }

        public IEnumerable<Planta> FindAllAlturaMax(double alturaMax)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllAlturaMin(double alturaMin)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllAmbiente(int idAmbiente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllNombre(string texto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllTipo(int IdTipo)
        {
            throw new NotImplementedException();
        }

        public Planta FindById(int id)
        {
            Planta buscada = null;

            SqlConnection con = Conexion.ObtenerConexion();
            string sql = "SELECT * FROM Plantas WHERE Id=@id;";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    buscada = CrearPlanta(reader);
                    buscada.Ambiente = stringToAmbiente(reader.GetString(6));
                    buscada.Ficha = CrearFicha(reader.GetInt32(2));
                    buscada.NombresVulgares = CrearNombresVul(reader.GetInt32(0));
                }

                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return buscada;
        }

        public TipoAmbiente stringToAmbiente(string tipo)
        {
            TipoAmbiente ambiente = (TipoAmbiente)(-1);

            foreach (TipoAmbiente amb in (TipoAmbiente[])Enum.GetValues(typeof(TipoAmbiente))){
                if(amb.ToString() == tipo)
                {
                    ambiente = amb;
                }
            }

            return ambiente;
        }

        public bool Remove(int id)
        {
            bool ok = false;

            SqlConnection con = Conexion.ObtenerConexion();

            string sql = "DELETE FROM Plantas WHERE Id=@id;";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                Conexion.AbrirConexion(con);
                int filasAfectadas = command.ExecuteNonQuery();
                ok = filasAfectadas == 1;
                Conexion.CerrarConexion(con);
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return ok;
        }

        public bool Update(Planta obj)
        {
            throw new NotImplementedException();
        }
    }
}
