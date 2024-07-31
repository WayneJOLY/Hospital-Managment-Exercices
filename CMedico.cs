using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CMedico : CPersonalDeSanidad
    {
        //private uint legajo;
        //private string nombre;
        //private string apellido;
        //private uint aniDeIngreso;
        //private string categoriaProfesional;
        //private uint numeroDeMatricula;
        private string especialidad;
        private string servicio;  //PARA SABER EN QUÉ SERVICIO ESTA TRABAJANDO
        private float dineroTotal;
        public CMedico(uint legajo, string nombre, string apellido, uint aniDeIngreso, string categoriaProfesional, uint numeroDeMatricula,string especialidad,string servicio) : base(legajo, nombre, apellido, aniDeIngreso,categoriaProfesional,numeroDeMatricula)
        { 
            this.especialidad = especialidad ;
            this.servicio = servicio ;
        }

        public string GetEspecialidad() { return especialidad ; }
        public string GetServicio() {  return servicio ; }


        //public override float HaberMensual()
        //{
        //    if( especialidad== "Jefe de Servicio") { return base.HaberMensual() + SetBono*1.5 ; }
        //    if (especialidad == "Titular") { return base.HaberMensual() + SetBono ; }
        //    if (especialidad == "Asociado") { return base.HaberMensual() + SetBono *0.8; }
        //    if (especialidad == "Residente") { return base.HaberMensual() + SetBono * 0.5; }
        //}
        public override string ToString()
        {
            string datos = base.ToString();
            datos += "\t\tESPECIALIDAD :" + this.especialidad + "\tSERVICIO   :" + this.servicio;
            return datos;
        }
    }
}
