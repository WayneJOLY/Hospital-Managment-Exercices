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
        private string codigo;
        private string nombreDeServicio;
        private CMedico jefe;
        public ArrayList ListaDeEmpleadosDelServicio;
        public ArrayList ListaDeConsultoriosDelServicio;
        public ArrayList LISTADEPACIENTES;
        public CServicio(string codigo, string nombre, CMedico jefe)
        {
            this.codigo = codigo;
            this.nombreDeServicio = nombre;
            this.jefe = jefe;

            ListaDeEmpleadosDelServicio = new ArrayList();
            ListaDeConsultoriosDelServicio = new ArrayList();
            LISTADEPACIENTES = new ArrayList();
        }
        /********************************************************************************/

        public CPaciente BuscarPaciente(string historial)
        {
            foreach (CPaciente paciente in LISTADEPACIENTES)
            {
                if (paciente.GetHistorialClinica() == historial)
                {
                    return paciente;
                }


            }
            return null;
        }

        public bool AgregarPacienteAlSercicio(CPaciente paciente)
        {
            CPaciente aux = BuscarPaciente(paciente.GetHistorialClinica());
            if (aux == null)
            {
                LISTADEPACIENTES.Add(paciente);
            }

            return false;
        }

        public string ListaDeLosPacientesDelHospital()
        {
            string PAC = "\n LOS PACIENTES DEL HOSPITAL SON :\n";
            foreach (CPaciente paciente in LISTADEPACIENTES)
            {
                PAC += paciente.ToString();
            }

            return PAC;
        }
        /*****************************************************************************************************/
        public string getCodigo() { return this.codigo; }
        public string getNombre() { return this.nombreDeServicio; }
        public CMedico getJefe() { return this.jefe; }
        
        public void setJefe(CMedico jefe) {  this.jefe = jefe; }
        public CEmpleado? BuscarEmpleado( uint legajo )
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
            CEmpleado aux = BuscarEmpleado(empleado.GetLegajo());

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
            
                if (empleado is CMedico)
                {
                    CMedico medico = (CMedico)empleado;
                    datos += medico.ToString();
                }
                else
                if (empleado is CPersonalDeApoyo)
                {
                    CPersonalDeApoyo medico = (CPersonalDeApoyo)empleado;
                    datos += medico.ToString();
                }
                else
                if (empleado is CPersonalDeSanidad)
                {
                    CPersonalDeSanidad medico = (CPersonalDeSanidad)empleado;
                    datos += medico.ToString();
                }
                else if (empleado is CEmpleado)
                {

                    datos += empleado.ToString();
                }
                //AUN NO TERMINA
            }

            return datos;
        }

        public bool AgregarConsultorio(CConsultorio consultorio)
        {
            CConsultorio? consul=BuscarConsultorio(consultorio.GetCodigo());
            if(consul==null)
            {
                ListaDeConsultoriosDelServicio.Add(consultorio);
                return true;
            }
            return false;
        }

        public bool SacarConsultorio(CConsultorio consultorio)
        {
            CConsultorio? consul = BuscarConsultorio(consultorio.GetCodigo());
            if (consul != null)
            {
                ListaDeConsultoriosDelServicio.Remove(consul);
                return true;
            }
            return false;
        }
        public CConsultorio? BuscarConsultorio(uint codigo)
        {
            foreach( CConsultorio consultorio in ListaDeConsultoriosDelServicio)
            {
                if(consultorio.GetCodigo() == codigo)
                {
                    return consultorio;
                }
            }
            return null;
        }

        public string ListaDelosConsultorios()
        {
            string datos = "LISTA DE CONSULTORIO DEL SERVICIO " + this.nombreDeServicio;
            foreach(CConsultorio consultorio in ListaDeConsultoriosDelServicio)
            {
                datos += consultorio.ToString();
            }
            return datos;
        }
        public float SumaDeHaberes()
        {
            float suma=0;

            foreach (CEmpleado empleado in ListaDeEmpleadosDelServicio)
            {
                suma += empleado.HaberMensual();
               
            }

            return suma;
        }
        public override string ToString()
        {
            string datos = "";
            datos += "\n Nombre :" + this.nombreDeServicio + "\nCodigo :" + this.codigo + "\nJefe :" + this.jefe.ToString();
            datos += "\n LISTA DE TRABAJADORES \n";
            datos += ListaDeLosEmpleados();
            datos += "LA SUMA DE SUS HABERES MENSUAL ES " + SumaDeHaberes().ToString();
            return datos ;
        }
    }
}
