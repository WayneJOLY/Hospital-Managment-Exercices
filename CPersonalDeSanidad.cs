using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CPersonalDeSanidad : CEmpleado
    {
        //private uint legajo;
        //private string nombre;
        //private string apellido;
        private uint aniDeIngreso;
        private string categoriaProfesional;
        private uint numeroDeMatricula;
        public CPersonalDeSanidad(uint legajo, string nombre, string apellido, uint aniDeIngreso, string categoriaProfesional, uint numeroDeMatricula) : base(legajo, nombre, apellido, aniDeIngreso)
        {
            this.numeroDeMatricula = numeroDeMatricula;
            this.categoriaProfesional = categoriaProfesional;
        }

        //public uint GetLegajo() { return legajo; }
        //public string GetNombre() { return nombre; }
        //public string GetApellido() { return apellido; } 
        public uint GetAniDeIngreso() {  return aniDeIngreso; }
        public string GetCategoriaProfesional() {  return categoriaProfesional; }
        public uint GetNumeDeMatricula(uint numeDeMatricula) {  return numeroDeMatricula; }


        public override string ToString()
        {
            string datos=base.ToString();
            datos += "\t CATEGORIA  " + this.categoriaProfesional + "\tMATRICULA " + this.numeroDeMatricula;
            return datos;

        }
    }
}
