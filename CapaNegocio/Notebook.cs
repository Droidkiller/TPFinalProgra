
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace CapaNegocio
{
    public class Notebook
    {
        #region Variables
        private int id;
        private string modelo;
        private double tamañoPantalla;
        private int memoria;
        private double peso;
        private int fkCPU;
        private Procesador cpu;
        private int fkAlm;
        private Almacenamiento alm;
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

        public double TamañoPantalla
        {
            get
            {
                return tamañoPantalla;
            }

            set
            {
                tamañoPantalla = value;
            }
        }

        public int Memoria
        {
            get
            {
                return memoria;
            }

            set
            {
                memoria = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }
        [Browsable(false)]
        public int FkCPU
        {
            get
            {
                return fkCPU;
            }

            set
            {
                fkCPU = value;
            }
        }

        public Procesador Cpu
        {
            get
            {
                if(cpu == null && fkCPU != 0)
                {
                    cpu = Procesador.BuscarPorId(fkCPU);
                }
                return cpu;
            }

            set
            {
                cpu = value;
            }
        }
        [Browsable(false)]
        public int FkAlm
        {
            get
            {
                return fkAlm;
            }

            set
            {
                fkAlm = value;
            }
        }

        public Almacenamiento Alm
        {
            get
            {
                if (alm == null && fkAlm != 0)
                {
                    alm = Almacenamiento.BuscarPorId(fkAlm);
                }
                return alm;
            }

            set
            {
                alm = value;
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
        public Notebook()
        {
            id = 0;
            modelo = "";
            tamañoPantalla = 0;
            memoria = 0;
            peso = 0;
            fkCPU = 0;
            fkAlm = 0;
            fkMarca = 0;
        }

        public Notebook(int id, string modelo, double tamañoPantalla, int memoria, double peso, int fkCPU, int fkAlm, int fkMarca)
        {
            this.id = id;
            this.modelo = modelo;
            this.tamañoPantalla = tamañoPantalla;
            this.memoria = memoria;
            this.peso = peso;
            this.fkCPU = fkCPU;
            this.fkAlm = fkAlm;
            this.fkMarca = fkMarca;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return modelo;
        }

        public void Guardar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            eNotebook fila = new eNotebook();

            if (this.id != 0) //detectamos que es uno nuevo
            {
                var res = from x in dc.eNotebooks where x.id == this.id select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else //no lo encontramos.. mostramos error
                    throw new Exception("Id no encontrado en Notebook");
            }


            fila.modelo = modelo;
            fila.tamañoPantalla = tamañoPantalla;
            fila.memoria = memoria;
            fila.peso = peso;

            fkMarca = this.Marca.Id;

            if (this.Marca.Id == 0)
            {
                fila.eMarca = this.Marca.Guardar(dc);
            }
            else
            {
                fila.idMarca = fkMarca;
            }

            fkCPU = this.cpu.Id;

            if (this.cpu.Id == 0)
            {
                fila.eProcesador = this.cpu.Guardar(dc);
            }
            else
            {
                fila.idProcesador= fkCPU;
            }

            fkAlm = Alm.Id;

            if (alm.Id == 0)
            {
                fila.eAlmacenamiento = alm.Guardar(dc);
            }
            else
            {
                fila.idAlmacenamiento = fkAlm;
            }

            if (this.id == 0)
                dc.eNotebooks.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.id = fila.id;
        }

        public void Eliminar()
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eNotebooks where x.id == this.id select x;
            if (res.Count() > 0)
            {
                dc.eNotebooks.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Notebook no encontrada");
        }

        public static List<Notebook> Buscar(string buscado = "")
        {
            List<Notebook> notebooks = new List<Notebook>();
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eNotebooks
                      where buscado == ""
                      || x.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.tamañoPantalla.ToString().Contains(buscado.ToLower().Trim())
                      || x.memoria.ToString().Contains(buscado.ToLower().Trim())
                      || x.peso.ToString().Contains(buscado.ToLower().Trim())
                      || x.id.ToString() == buscado.Trim()
                      || x.eAlmacenamiento.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.eProcesador.modelo.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.eMarca.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())

                      select x;

            foreach (eNotebook em in res)
            {
                notebooks.Add(new Notebook(em.id, em.modelo, Convert.ToDouble(em.tamañoPantalla), Convert.ToInt32(em.memoria), Convert.ToDouble(em.peso), Convert.ToInt32(em.idProcesador), Convert.ToInt32(em.idAlmacenamiento), Convert.ToInt32(em.idMarca)));
            }
            return notebooks;
        }

        public static Notebook BuscarPorId(int id)
        {
            DSDataContext dc = new DSDataContext(Conexion.DarStrConexion());
            var res = from x in dc.eNotebooks
                      where x.id == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Notebook(x.id, x.modelo, Convert.ToDouble(x.tamañoPantalla), Convert.ToInt32(x.memoria), Convert.ToDouble(x.peso), Convert.ToInt32(x.idProcesador), Convert.ToInt32(x.idAlmacenamiento),Convert.ToInt32(x.idMarca));
            }
            return null;
        }
        #endregion
    }
}
