using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        private   float bono;

        //private static float bonoMedico;
        //private static float bonoEnfermero;
        //private static float bonoTecnico;



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

        /*-------------                     */
        public void SetBono(float bono)
        {
            this.bono = bono;
        }

        //public static void SetBono(float bon, string categoriaProfesional)
        //{
        //    if (categoriaProfesional == "Medico") { bonoMedico = bon; }
        //    if (categoriaProfesional == "Enfermero") { bonoEnfermero = bon; }
        //    if (categoriaProfesional == "Tecnico") { bonoTecnico = bon; }
        //}

        //public static float GetBono(string categoriaProfesional)
        //{
        //    if (categoriaProfesional == "Medico") {return CPersonalDeSanidad.bonoMedico; }
        //    if (categoriaProfesional == "Enfermero") { return CPersonalDeSanidad.bonoEnfermero; }
        //    if (categoriaProfesional == "Tecnico") return CPersonalDeSanidad.bonoTecnico; }

        //return 0;
        //}

        public override float HaberMensual()
        {
            return base.HaberMensual() + bono;
        }
        public override string ToString()
        {
            string datos=base.ToString();
            datos += "\t CATEGORIA  " + this.categoriaProfesional + "\tMATRICULA " + this.numeroDeMatricula  + "\t BONO :"+ this.bono.ToString()+ "\t Antes de bono :"+ base.HaberMensual().ToString();
            return datos;
        }
    }
}
