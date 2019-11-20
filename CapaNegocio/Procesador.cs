using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
namespace CapaNegocio
{
    public class Procesador
    {
        #region Variables
        private int id;
        private string modelo;
        private float frecuencia;
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

        public float Frecuencia
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

        public Procesador(int id, string modelo, float frecuencia, int nroNucleos, int fkGraficos, int fkMarca)
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
                    throw new Exception("Id no encontrado en Articulo");
            }


            fila.modelo = modelo;
            fila.frecuencia = frecuencia;
            fila.nroNucleos = nroNucleos;

            if (this.Marca.Id == 0)
            {
                fila.eMarca = this.Marca.Guardar(dc);
            }
            else
            {
                fila.idMarca = fkMarca;
            }

            if (this.id == 0)
                dc.eProcesadors.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.id = fila.id;
        }
        #endregion
    }
}
