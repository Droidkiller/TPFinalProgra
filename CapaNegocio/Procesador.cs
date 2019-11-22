using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace CapaNegocio
{
    public class Procesador
    {
        #region Variables
        private int id;
        private string modelo;
        private double frecuencia;
        private int nroNucleos;
        private Graficos graficos;
        private int fkGraficos;
        private Marca marca;
        private int fkMarca;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public double Frecuencia
        {
            get
            {
                return frecuencia;
            }

            set
            {
                frecuencia = value;
            }
        }

        public int NroNucleos
        {
            get
            {
                return nroNucleos;
            }

            set
            {
                nroNucleos = value;
            }
        }

        public Graficos Graficos
        {
            get
            {
                if (graficos == null && fkGraficos != 0)
                {
                    graficos = Graficos.BuscarPorId(fkGraficos);
                }
                return graficos;
            }

            set
            {
                graficos = value;
            }
        }
        [Browsable(false)]
        public int FkGraficos
        {
            get
            {
                
                return fkGraficos;
            }

            set
            {
                fkGraficos = value;
            }
        }

        public Marca Marca
        {
            get
            {
                if(marca==null && fkMarca!=0)
                {
                    marca = Marca.BuscarPorId(fkMarca);
                }
                return marca;
            }

            set
            {
                marca = value;
            }
        }
        [Browsable(false)]
        public int FkMarca
        {
            get
            {
                return fkMarca;
            }

            set
            {
                fkMarca = value;
            }
        }
        #endregion

        #region Constructores
        public Procesador()
        {
            id = 0;
            modelo = "";
            frecuencia = 0;
            nroNucleos = 0;
            fkGraficos = 0;
            fkMarca = 0;
        }

        public Procesador(int id, string modelo, double frecuencia, int nroNucleos, int fkGraficos, int fkMarca)
        {
            this.id = id;
            this.modelo = modelo;
            this.frecuencia = frecuencia;
            this.nroNucleos = nroNucleos;
            this.fkGraficos = fkGraficos;
            this.fkMarca = fkMarca;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Concat(modelo, " ", frecuencia, "GHz");
        }

        public void Guardar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            eProcesador fila = new eProcesador();

            if (this.id != 0) //detectamos que es uno nuevo
            {
                var res = from x in dc.eProcesadors where x.id == this.id select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else //no lo encontramos.. mostramos error
                    throw new Exception("Id no encontrado en Procesadores");
            }


            fila.modelo = modelo;
            fila.frecuencia = frecuencia;
            fila.nroNucleos = nroNucleos;
            fkMarca = this.Marca.Id;

            if (this.Marca.Id == 0)
            {
                fila.eMarca = this.Marca.Guardar(dc);
            }
            else
            {
                fila.idMarca = fkMarca;
            }

            fkGraficos = this.Graficos.Id;

            if (this.Graficos.Id == 0)
            {
                fila.eGraficos = this.Graficos.Guardar(dc);
            }
            else
            {
                fila.idGraficos = fkGraficos;
            }

            if (this.id == 0)
                dc.eProcesadors.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.id = fila.id;
        }

        public eProcesador Guardar(DSDataContext dcOri)
        {
            try
            {
                DSDataContext dc = dcOri;
                eProcesador fila = new eProcesador();
                fila.modelo = this.modelo;

                if (this.id == 0)
                {
                    dc.eProcesadors.InsertOnSubmit(fila);
                }
                else
                {
                    var res = from x in dc.eProcesadors where x.id == this.id select x;
                    if (res.Count() > 0)
                    {
                        fila = res.First();
                        fila.modelo = this.modelo;
                    }
                    else
                        throw new Exception("Id no encontrado en Procesadores");
                }
                return fila;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar()
        {            
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eProcesadors where x.id == this.id select x;
            if (res.Count() > 0)
            {
                dc.eProcesadors.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Procesador no encontrado");
        }

        public static List<Procesador> Buscar(string buscado = "")
        {
            List<Procesador> procesadores = new List<Procesador>();
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eProcesadors
                      where buscado == ""
                      || x.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.frecuencia.ToString().Contains(buscado.ToLower().Trim())
                      || x.nroNucleos.ToString().Contains(buscado.ToLower().Trim())
                      || x.id.ToString() == buscado.Trim()
                      || x.eMarca.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.eGraficos.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      
                      select x;

            foreach (eProcesador em in res)
            {
                procesadores.Add(new Procesador(em.id, em.modelo, Convert.ToDouble(em.frecuencia), Convert.ToInt32(em.nroNucleos), Convert.ToInt32(em.idGraficos), Convert.ToInt32(em.idMarca)));
            }

            return procesadores;
        }

        public static IQueryable ConsultaEjemplo()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var resultado = from x in dc.eProcesadors
                            select new
                            {
                                Modelo = x.modelo,
                                Frecuencia = x.frecuencia,
                                NroNucleos = x.nroNucleos,
                                Graficos = x.eGraficos.modelo,
                                Marca = x.eMarca.nombre,
                            };
            return resultado;
        }

        public static DataTable BuscarPorDT(string buscado)
        {
            SqlConnection sqlConn = new SqlConnection(Conexion.DarStrConexion());
            try
            {
                sqlConn.Open();
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(string.Concat("select p.id, p.modelo 'Modelo', p.frecuencia 'Frecuencia', p.nroNucleos 'Numero de nucleos', m.nombre 'Marca' from procesador p inner join marca m on p.idMarca = m.id where p.modelo like '%", buscado, "%' or m.nombre like '%", buscado, "%'"), sqlConn);
                adapter.Fill(ds);
                return ds.Tables[0]; //esto es si solo tiene 1 tabla, si tiene mas de una uso DataSet como tipo de dato a retornar
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }

        }

        public static Procesador BuscarPorId(int id)
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eProcesadors
                      where x.id == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Procesador(x.id, x.modelo, Convert.ToDouble(x.frecuencia), Convert.ToInt32(x.nroNucleos), Convert.ToInt32(x.idGraficos), Convert.ToInt32(x.idMarca));
            }
            return null;
        }

        #endregion
    }
}
