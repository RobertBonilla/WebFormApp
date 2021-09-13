using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class DetListaRepository : IDetListaRepository
    {
        private readonly string _connectionString;

        public DetListaRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
        public DetLista eliminarDetLista(DetLista model)
        {
            DetLista newModel = null;
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
                            cmd.CommandText = "deleteDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("detListaId", model.DetListaId);
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

        public IEnumerable<DetListaProducto> getListaProductos(Lista model)
        {
            List<DetListaProducto> list = new List<DetListaProducto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT det.detListaId,det.listaId,det.productoId,det.valorUnitario,det.cantidad,det.subTotal,
                                    pro.nombre,pro.descripcion,pro.valor
                                    FROM detLista det
                                    INNER JOIN Producto pro on det.productoId = pro.productoId WHERE det.listaId = @listaId";
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
                                    list.Add(new DetListaProducto()
                                    {
                                        detLista = new DetLista()
                                        {
                                            DetListaId = (sdr["detListaId"] != null) ? int.Parse(sdr["detListaId"].ToString()) : 0,
                                            ListaId = (sdr["listaId"] != null) ? int.Parse(sdr["listaId"].ToString()) : 0,
                                            ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                            Cantidad = (sdr["cantidad"] != null) ? int.Parse(sdr["cantidad"].ToString()) : 0,
                                            ValorUnitario = (sdr["valorUnitario"] != null) ? decimal.Parse(sdr["valorUnitario"].ToString()) : 0,
                                            SubTotal = (sdr["subTotal"] != null) ? decimal.Parse(sdr["subTotal"].ToString()) : 0
                                        },
                                        Producto = new Producto()
                                        {
                                            ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                            Nombre = (sdr["nombre"] != null) ? sdr["nombre"].ToString() : "",
                                            Descripcion = (sdr["descripcion"] != null) ? sdr["descripcion"].ToString() : "",
                                            Valor = (sdr["valor"] != null) ? decimal.Parse(sdr["valor"].ToString()) : 0
                                        }
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

        public DetLista insertarDetLista(DetLista model)
        {
            DetLista newModel = null;
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
                            cmd.CommandText = "insertDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("listaId", model.ListaId);
                            cmd.Parameters.AddWithValue("productoId", model.ProductoId);
                            cmd.Parameters.AddWithValue("valorUnitario", model.ValorUnitario);
                            cmd.Parameters.AddWithValue("cantidad", model.Cantidad);
                            cmd.Parameters.AddWithValue("subTotal", model.SubTotal);
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

        public DetLista modificarDetLista(DetLista model)
        {
            DetLista newModel = null;
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
                            cmd.CommandText = "updateDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("detListaId", model.DetListaId);
                            cmd.Parameters.AddWithValue("valorUnitario", model.ValorUnitario);
                            cmd.Parameters.AddWithValue("cantidad", model.Cantidad);
                            cmd.Parameters.AddWithValue("subTotal", model.SubTotal);
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
    }
}
