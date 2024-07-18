using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CServicio
    {
        private string codiogo;
        private string nombre;
        private CEmpleado jefe;
        private ArrayList ListaDeEmpleadosDelServicio;
        public CServicio(string codiogo, string nombre, CEmpleado jefe)
        {
            this.codiogo = codiogo;
            this.nombre = nombre;
            this.jefe = jefe;

            ListaDeEmpleadosDelServicio = new ArrayList();
        }

        public string getCodigo() { return this.codiogo; }
        public string getNombre() { return this.nombre; }
        public CEmpleado getCempleado() { return this.jefe; }

        public CEmpleado BuscarEmpleado( uint legajo )
        {
            foreach(CEmpleado empleado in ListaDeEmpleadosDelServicio)
            {
                if(empleado.GetLegajo()== legajo )
                {
                    return empleado;
                }
            }

            return null;
        }

        public bool AgreagEmpeado(CEmpleado empleado)
        {
            CEmpleado aux =BuscarEmpleado(empleado.GetLegajo());

            if(aux == null)
            {
                ListaDeEmpleadosDelServicio.Add(empleado);
                return true;
            }
            return false;
        }

        public bool SacarEmpeado(CEmpleado empleado)
        {
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());

            if (aux != null)
            {
                ListaDeEmpleadosDelServicio.Remove(empleado);
                return true;
            }
            return false;
        }
        public string ListaDeLosEmpleados()
        {
            string datos = "";

            foreach(CEmpleado empleado in ListaDeEmpleadosDelServicio)
            {
                datos += empleado.ToString();
            }

            return datos;
        }
        public override string ToString()
        {
            string datos = "";
            datos += "\n Nombre :" + this.nombre + "\nCodigo :" + this.codiogo + "\nJefe :" + this.jefe.ToString();
            return datos ;
        }
    }
}
