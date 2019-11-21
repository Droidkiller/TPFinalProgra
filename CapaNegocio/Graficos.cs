using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Graficos
    {
        #region Variables
        private int id;
        private string modelo;
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
        #endregion

        #region Constructores
        public Graficos()
        {
            id = 0;
            modelo = "";
        }

        public Graficos(int id, string modelo)
        {
            this.id = id;
            this.modelo = modelo;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return modelo;
        }

        public eGraficos Guardar(DSDataContext dcOri)
        {
            try
            {
                DSDataContext dc = dcOri;
                eGraficos fila = new eGraficos();
                fila.modelo = this.modelo;

                if (this.id == 0)
                {
                    dc.eGraficos.InsertOnSubmit(fila);
                }
                else
                {
                    var res = from x in dc.eGraficos where x.id == this.id select x;
                    if (res.Count() > 0)
                    {
                        fila = res.First();
                        fila.modelo = this.modelo;
                    }
                    else
                        throw new Exception("Id no encontrado en Graficos");
                }
                return fila;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar()
        {
            try
            {
                DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
                eGraficos f = Guardar(dc);
                dc.SubmitChanges();
                this.id = f.id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar()
        {
            try
            {
                DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
                var res = from x in dc.eGraficos where x.id == this.id select x;
                if (res.Count() > 0)
                {
                    dc.eGraficos.DeleteOnSubmit(res.First());
                    dc.SubmitChanges();
                }
                else
                    throw new Exception("Gráficos no encontrados");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Graficos> Buscar(string buscado = "")
        {
            try
            {
                List<Graficos> marcas = new List<Graficos>();
                DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
                var res = from x in dc.eGraficos
                          where buscado == ""
                          || x.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                          || x.id.ToString() == buscado.Trim()
                          select x;

                foreach (eGraficos em in res)
                {
                    marcas.Add(new Graficos(em.id, em.modelo));
                }
                return marcas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Graficos BuscarPorId(int id)
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eGraficos
                      where x.id == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Graficos(x.id, x.modelo);
            }
            return null;
        }

        #endregion  
    }
}
