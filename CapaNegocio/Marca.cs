using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Marca
    {
        #region Variables
        private int id;
        private string nombre;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        #endregion

        #region Constructores
        public Marca()
        {
            id = 0;
            nombre = "";
        }

        public Marca(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return nombre;
        }

        public eMarca Guardar(DSDataContext dcOri)
        {
            try
            {              
                DSDataContext dc = dcOri;
                eMarca fila = new eMarca();
                fila.nombre = this.nombre;

                if (this.id == 0) 
                {
                    dc.eMarcas.InsertOnSubmit(fila);
                }
                else 
                {
                    var res = from x in dc.eMarcas where x.id == this.id select x;
                    if (res.Count() > 0)
                    {
                        fila = res.First();
                        fila.nombre = this.nombre;
                    }
                    else
                        throw new Exception("Id no encontrado en Marca");
                }
                return fila;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Guardar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            eMarca f = Guardar(dc);
            dc.SubmitChanges();
            this.id = f.id;

        }

        public void Eliminar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eMarcas where x.id == this.id select x;
            if (res.Count() > 0)
            {
                dc.eMarcas.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Marca no encontrada");

        }

        public static List<Marca> Buscar(string buscado = "")
        {
            List<Marca> marcas = new List<Marca>();
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eMarcas
                      where buscado == ""
                      || x.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.id.ToString() == buscado.Trim()
                      select x;

            foreach (eMarca em in res)
            {
                marcas.Add(new Marca(em.id, em.nombre));
            }

            return marcas;
        }

        public static Marca BuscarPorId(int id)
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eMarcas
                      where x.id == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Marca(x.id, x.nombre);
            }
            return null;
        }
        #endregion
    }
}
