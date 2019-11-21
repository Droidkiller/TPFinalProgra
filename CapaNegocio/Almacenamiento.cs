using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class Almacenamiento
    {
        #region Variables
        private int id;
        private string modelo;
        private int capacidad;
        private double velocidad;
        private string tipo;
        private int fkMarca;
        private Marca marca;
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

        public int Capacidad
        {
            get
            {
                return capacidad;
            }

            set
            {
                capacidad = value;
            }
        }

        public double Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
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

        public Marca Marca
        {
            get
            {
                if (marca == null && fkMarca != 0)
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
        #endregion

        #region Constructores
        public Almacenamiento()
        {
            id = 0;
            modelo = "";
            capacidad = 0;
            velocidad = 0;
            tipo = "";
            fkMarca = 0;
        }

        public Almacenamiento(int id, string modelo, int capacidad, double velocidad, string tipo, int fkMarca)
        {
            this.id = id;
            this.modelo = modelo;
            this.capacidad = capacidad;
            this.velocidad = velocidad;
            this.tipo = tipo;
            this.fkMarca = fkMarca;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Concat(modelo, " ", capacidad, "GB");
        }

        public void Guardar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            eAlmacenamiento fila = new eAlmacenamiento();

            if (this.id != 0) //detectamos que es uno nuevo
            {
                var res = from x in dc.eAlmacenamientos where x.id == this.id select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else //no lo encontramos.. mostramos error
                    throw new Exception("Id no encontrado en Almacenamiento");
            }


            fila.modelo = modelo;
            fila.capacidad = capacidad;
            fila.velocidad = velocidad;
            fila.tipo = tipo;
            fkMarca = Marca.Id;

            if (this.Marca.Id == 0)
            {
                fila.eMarca = this.Marca.Guardar(dc);
            }
            else
            {
                fila.idMarca = fkMarca;
            }

            if (this.id == 0)
                dc.eAlmacenamientos.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.id = fila.id;
        }

        public void Eliminar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eAlmacenamientos where x.id == this.id select x;
            if (res.Count() > 0)
            {
                dc.eAlmacenamientos.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Unidad de almacenamiento no encontrada");
        }

        public static List<Almacenamiento> Buscar(string buscado = "")
        {
            List<Almacenamiento> almacenamientos = new List<Almacenamiento>();
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eAlmacenamientos
                      where buscado == ""
                      || x.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.capacidad.ToString().Contains(buscado.ToLower().Trim())
                      || x.velocidad.ToString().Contains(buscado.ToLower().Trim())
                      || x.tipo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.id.ToString() == buscado.Trim()
                      || x.eMarca.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())

                      select x;

            foreach (eAlmacenamiento em in res)
            {
                almacenamientos.Add(new Almacenamiento(em.id, em.modelo, Convert.ToInt32(em.capacidad), Convert.ToDouble(em.velocidad), em.tipo, Convert.ToInt32(em.idMarca)));
            }
            return almacenamientos;
        }

        public static DataTable BuscarPorDT(string buscado)
        {
            SqlConnection sqlConn = new SqlConnection(Conexion.DarStrConexion());
            try
            {
                sqlConn.Open();
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(string.Concat("select a.id, a.modelo 'Modelo', a.capacidad 'Tamaño', a.velocidad 'Velocidad', m.nombre 'Marca' from almacenamiento a inner join marca m on a.idMarca = m.id where a.modelo like '%", buscado, "%' or m.nombre like '%", buscado, "%' or a.capacidad like '%", buscado, "%' or a.velocidad like '%", buscado, "%'"), sqlConn);
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

        public static Almacenamiento BuscarPorId(int id)
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eAlmacenamientos
                      where x.id == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Almacenamiento(x.id, x.modelo, Convert.ToInt32(x.capacidad), Convert.ToDouble(x.velocidad), x.tipo, Convert.ToInt32(x.idMarca));
            }
            return null;
        }
        #endregion
    }
}
