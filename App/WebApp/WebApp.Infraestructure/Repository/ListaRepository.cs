using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;
using System.Configuration;
using System.Data;

namespace WebApp.Infraestructure.Repository
{
    public class ListaRepository : IListaRepository
    {
        private readonly string _connectionString;

        public ListaRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
        public Lista GetLista(Lista model)
        {
            Lista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT listaId,fechaCreacion,fechaUpdate,descripcion FROM Lista WHERE listaId = @listaId";
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("listaId", model.ListaId);
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    newModel = new Lista()
                                    {
                                        ListaId = (sdr["listaId"] != null) ? int.Parse(sdr["listaId"].ToString()) : 0,
                                        FechaCreacion = (sdr["fechaCreacion"] != null) ? sdr["fechaCreacion"].ToString() : "",
                                        FechaUpdate = (sdr["fechaUpdate"] != null) ? sdr["fechaUpdate"].ToString() : "",
                                        Descripcion = sdr["descripcion"].ToString()
                                    };
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }

        public Lista InsertarLista(Lista model)
        {
            Lista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "insertList";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("descripcion", model.Descripcion);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            newModel = model;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }

        public Lista ModificarLista(Lista model)
        {
            Lista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "updateList";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("descripcion", model.Descripcion);
                            cmd.Parameters.AddWithValue("listaId", model.ListaId);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            newModel = model;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }

        public IEnumerable<Lista> ObtenerLista()
        {
            List<Lista> list = new List<Lista>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT listaId,fechaCreacion,fechaUpdate,descripcion FROM Lista";
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    list.Add(new Lista()
                                    {
                                        ListaId = (sdr["listaId"] != null) ? int.Parse(sdr["listaId"].ToString()) : 0,
                                        FechaCreacion = (sdr["fechaCreacion"] != null) ? sdr["fechaCreacion"].ToString() : "",
                                        FechaUpdate = (sdr["fechaUpdate"] != null) ? sdr["fechaUpdate"].ToString() : "",
                                        Descripcion = sdr["descripcion"].ToString()
                                    });
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return list;
        }
    }
}
