using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CHospital
    {
        private ArrayList ListaDeTrabajadores;
        private ArrayList ListaDeServicios;

        public CHospital()
        {
            ListaDeTrabajadores = new ArrayList();
            ListaDeServicios = new ArrayList();
        }

        public CEmpleado BuscarEmpleado(uint legajo)
        {
            foreach (CEmpleado empleado in ListaDeTrabajadores)
            {
                if (legajo == empleado.GetLegajo())
                {
                    return (CEmpleado)empleado;
                }
            }
            return null;
        }

        public bool AgregarEmpleado(CEmpleado empleado)
        {
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());
            if (aux == null)
            {
                ListaDeTrabajadores.Add(empleado);
                return true;
            }
        return false;
        }

        public bool EliminarEmpleado(CEmpleado empleado)
        {
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());
            if(aux != null)
            {
                ListaDeTrabajadores.Remove(empleado);
                return true;
            }
            return false;
        }

        //-------------------------INICIO DE  FUNCIONES DE SERVICIO------------------------------------------

        public CServicio BuscarServicio(CServicio servicio)
        {
            foreach(CServicio ser in ListaDeServicios)
            {
                if(ser.getCodigo() == servicio.getCodigo()) { return servicio; }
            }
            return null ;
        }

        public bool AgregarServicio(CServicio servicio)
        {
            CServicio aux=BuscarServicio(servicio);

            if(aux != null)
            {
                ListaDeServicios.Add(aux);
                return true;
            }
            return false;
        }

        public bool AgregarEmpleadoAServicio(CEmpleado empleado,CServicio servicio) 
        {
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());
            CServicio auxServicio = BuscarServicio(servicio);

            if(aux != null && auxServicio !=null) 
            {
                auxServicio.AgreagEmpeado(empleado);
                return true;
            }

            return false; 
        }

        public bool SacarEmpleadoAServicio(CEmpleado empleado, CServicio servicio)//NO ESTOY TOTALMENTE SEGURO SI ES CORRECTO
        {
            CServicio auxServicio = BuscarServicio(servicio);
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());
            

            if (aux != null && auxServicio != null)
            {
                auxServicio.SacarEmpeado(empleado);
                return true;
            }

            return false;
        }
        //-------------------------FIN    DE  FUNCIONES DE SERVICIO------------------------------------------
        public string EmpleadosDelHospital()
        {
            string datos = "\n LA LISTA DE LOS EMPLEADOS DEL HOSPITAL";
            Console.WriteLine("Legajo \tNombre\t\tApellido\tAño de Ingreso Puesto\t");
            foreach (CEmpleado empleado in ListaDeTrabajadores)
            {
                if(empleado is CMedico)
                {
                    CMedico medico = (CMedico)empleado;
                    datos += medico.ToString();
                }
                if (empleado is CPersonalDeApoyo )
                {
                    CPersonalDeApoyo medico = (CPersonalDeApoyo)empleado;
                    datos += medico.ToString();
                }
                if (empleado is CPersonalDeSanidad)
                {
                    CPersonalDeSanidad medico = (CPersonalDeSanidad)empleado;
                    datos += medico.ToString();
                }
                if (empleado is CEmpleado)
                {
                    
                    datos += empleado.ToString();
                }
                //AUN NO TERMINA
            }

            return datos;
        }
    }
}
