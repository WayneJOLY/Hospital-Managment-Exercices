using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CPersonalDeApoyo:CEmpleado
    {
        private uint legajo;
        private string nombre;
        private string apellido;
        private uint aniDeIngreso;
        private string puesto;
        public CPersonalDeApoyo(uint legajo, string nombre, string apellido, uint aniDeIngreso,string puesto):base(legajo,nombre,apellido,aniDeIngreso)
        {
            this.puesto = puesto;
        }

        public string GetPuesto()
        {
            return this.puesto;
        }

        public void SetPuesto(string puesto) { this.puesto = puesto; }

        public override string ToString()
        {
            return base.ToString() + "Puesto :" +this.puesto;
        }
    }
}
