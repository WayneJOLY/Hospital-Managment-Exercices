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


        public override string ToString()
        {
            return "\n " + this.nombre + " "+ this.apellido + " " + this.legajo.ToString() + " "+this.aniDeIngreso.ToString();
        }
    }
}
