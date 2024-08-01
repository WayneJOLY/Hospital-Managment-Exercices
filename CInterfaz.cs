﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Interzonal_de_Haedo
{
    public class CInterfaz
    {

         static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public string MostrarOpcion()
        {
            Console.Clear();


            Console.WriteLine("[1] Ingrese el Monton de Regerencia y El Bono Profecional del Sindicato ");
            Console.WriteLine("[2] Registrar un Empleado ");
            Console.WriteLine("[3] Listar Los datos de Todos los Empleados del Hospital ");
            Console.WriteLine("[4] Registar un Servicio ");
            Console.WriteLine("[5] Asignar Un Empleado a Un Servicio ");
            Console.WriteLine("[6] Remplazar el Jefe de Un Servicio ");
            Console.WriteLine("[7] Listar los Datos de los Emplados de un Servicio ");
            Console.WriteLine("[8] Listar los Datos de un Emplado y sus Servicios ");
            Console.WriteLine("[9] Eliminar a un Empleado ");
            Console.WriteLine("[10] Listar todos los Datos del Hospital ");
            

            Console.WriteLine("[11] Agregar un Consultorio al Hospital ");
            Console.WriteLine("[12] Agregar un Consultorio a un Servicio ");
            Console.WriteLine("[13] Motrar la lista de  Consultorios de un Servicio ");
            Console.WriteLine("[14] Lista  de Consultorios  del Hospital");
            Console.WriteLine("[15] Listar de todos los Datos de los SERVICIOS del Hospital ");


            Console.WriteLine("[16] AgregarPacienteAlHospital ");
            Console.WriteLine("[17] Motrar la lista de los Paciente de Hospital ");
            Console.WriteLine("[18] Agregar Paciente a Sercvicio");
            Console.WriteLine("[19] Lista de Sercicios En Las Cuales esta El paciente ");
            return DarOpcion("Ingrese la Opcion Elegida");
        }

        public string DarOpcion(string mensaje) 
        {
            Console.WriteLine("Ingrese " + mensaje);
            return Console.ReadLine();
        }

        public char DevolverUnChar(string mensaje)
        {
            Console.WriteLine(mensaje);
            return char.Parse(Console.ReadLine());
        }

        public uint DevolverUnUint(string mensaje)
        {

            uint numero;
            bool resultado;
            do
            {
                Console.WriteLine(mensaje);
                resultado = uint.TryParse(Console.ReadLine(), out numero);
            } while (resultado ==false);
            return numero;
        }

        public string DevlverUnString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

       
    }
}
