using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CConsultorio
    {
        uint codigo;
        uint piso;
        string sector;

        public CConsultorio(uint codigo, uint piso,string sector)
        {
            this.codigo = codigo;
                this.piso = piso;
            this.sector = sector;
        }

        public uint GetCodigo() { return codigo; }
        public uint GetPiso() {  return piso; }
        public string GetSector() { return sector; }



        public override string ToString()
        {
            string datos = "\n CODIGO :" + this.codigo + "\n PISO :" + this.piso +"\n SECTOR :"+ this.sector;
            return datos;
        }

    }
}
