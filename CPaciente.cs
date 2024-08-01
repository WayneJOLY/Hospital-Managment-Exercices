using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CPaciente
    {

        private string historialClinica;
        private string nombre;
        private string apellido;
        private uint fechaDeNacimiento;
        private uint dni;
        private char sexo;
        private uint FECHADEALTA;

        public CPaciente( string historialClinica, string nombre, string apellido, uint dni,uint fechaDeNacimiento,char sexo)
        {

            this.historialClinica = historialClinica;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.sexo = sexo;
        }

        public void SetFechaDeAlta(uint ECHADEALTA)
        {
            this.FECHADEALTA = ECHADEALTA;
        }
        public string GetHistorialClinica() { return historialClinica;}

        public override string ToString()
        {
            string datos = "\n Nombre :" + this.nombre + "\n Apellido :" + this.apellido + "\n Numero de Historial clinica :" + this.historialClinica.ToString() + "\n Fecha de Nacimiento :" + this.fechaDeNacimiento.ToString() + "\n Sexo :" + this.sexo;


            return datos;
        }
    }
}
