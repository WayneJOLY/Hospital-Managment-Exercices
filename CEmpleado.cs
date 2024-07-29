using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CEmpleado
    {
        private uint legajo;
        private string nombre;
        private string apellido;
        private uint aniDeIngreso;
        public bool ESTA_EN_UN_SERVIVCIO;
        private static float monto;//


        public CEmpleado(uint legajo, string nombre, string apellido, uint aniDeIngreso)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.aniDeIngreso = aniDeIngreso;
        }

        public CEmpleado(uint legajo) 
        {
            this.legajo=legajo;
        }

        public uint GetLegajo()
        {
            return this.legajo;
        }

        public string GetNombre() { return this.nombre; }
        public string GetApellido() { return this.apellido; }
        public uint GetAnioDeIngreso() {  return this.aniDeIngreso; }

        public void SetLegajo(uint legajo) { this.legajo= legajo; }
        public void SetNombre(string nombre) {  this.nombre = nombre; }
        public void SetApellido(string Apellido) { this.apellido = Apellido; }

        public static float getMonto()
        {
            return monto;
        }
        public static void setMonto(float monto)
        {
            CEmpleado.monto = monto;
        }
        /*---------------- INICIO HABER MENSUAL ---------------------*/
        public float HaberMensual()
        {
            float total = 0;
            uint antiguedad = 2024 - aniDeIngreso;
            if (antiguedad < 2)                      { total = monto * (float)0.5; }
            if (antiguedad >= 2 && antiguedad < 4)   { total =  monto * (float)1.10; }
            if (antiguedad >= 8 && antiguedad < 10)  { total =  monto * (float)1.3; }
            if (antiguedad >= 10 && antiguedad < 12) { total = monto * (float)1.5; }
            if (antiguedad >= 12 && antiguedad < 14) { total = monto * (float)1.70; }
            if (antiguedad >= 14 && antiguedad < 16) { total = monto * (float)1.9; }
            if (antiguedad >= 16 && antiguedad < 18) { total = monto * (float)2.1; }
            if (antiguedad >= 18 && antiguedad < 20) { total = monto * (float)2.3; }
            if (antiguedad >= 20)                    { total = monto * (float)2.5; }

            return total;
        }
        /*------- FIN HABER MENSUAL  -----*/
        public override string ToString()
        {
            return "\n " + this.nombre + " "+ this.apellido + " " + this.legajo.ToString() + " "+this.aniDeIngreso.ToString() + "\t Haber "+this.HaberMensual().ToString();
        }
    }
}
