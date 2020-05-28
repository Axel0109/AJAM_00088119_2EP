using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Parcial_2.Properties.Modelos;

namespace Parcial_2.Properties.Controladores
{
    public class DireccionesC
    {
        public static object GetDirecciones()
        {
            var direcciones = new List<Direcciones>();
            DataTable TablaDirecciones = null;

            try
            {
                TablaDirecciones = BDconexion.ExecuteQuery("SELECT * FROM ADDRESS");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

            if (TablaDirecciones!= null)
                foreach (DataRow dr in TablaDirecciones.Rows)
                {
                    direcciones.Add(new Direcciones
                        (
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString()
                        )
                    );
                }

            return direcciones;
        }
        public static DataTable GetTablaDirecciones()
        {
            DataTable TablaDirecciones = null;

            try
            {
                TablaDirecciones = BDconexion.ExecuteQuery("SELECT * FROM ADDRESS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }

            return TablaDirecciones;
        }
    }
}