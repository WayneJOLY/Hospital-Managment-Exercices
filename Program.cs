using System.Runtime.ConstrainedExecution;

namespace Hospital_Interzonal_de_Haedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint legajo;
            string nombre, NombreDelServicio;
            string apellido,codigo;
            uint aniDeIngreso;
            string puesto;
            string categoriaProfesional, especialidad;
            uint numeroDeMatricula;

            Console.WriteLine("Hello, World!");

            char opcion,eleccion;
            
            CInterfaz interfaz= new CInterfaz();
            CHospital hospital= new CHospital();
            do
            {
                opcion=char.Parse(interfaz.MostrarOpcion());

                switch (opcion)
                {
                    case '1':
                        break;
                    case '2':
                            Console.WriteLine("Agregar Un Empleado");

                            legajo=interfaz.DevolverUnUint("Ingrese el Legajo de Empleado");
                            nombre=interfaz.DevlverUnString("Ingrese el Nombre de Empleado");
                            apellido = interfaz.DevlverUnString("Ingrese el Apellido de Empleado");
                            aniDeIngreso =interfaz.DevolverUnUint("Ingrese el Año  de ingreso del Empleado");

                            Console.WriteLine("\n QUÉ TIPO DE EMPLEADO QUIERE REGISTRAR ? \n [A] Personal de Sanidad \n [B] Personal de Apoyo ");
                            eleccion=char.Parse(Console.ReadLine());

                        switch (eleccion)
                        {
                            case'A':
                                categoriaProfesional = interfaz.DevlverUnString("Ingrese la Categoria Profecional");
                                numeroDeMatricula = interfaz.DevolverUnUint("Ingrese el Numero de Matricula");
                                break;
                            case 'B':
                                puesto = interfaz.DevlverUnString("Ingrese el puesto de Empleado");
                                CPersonalDeApoyo Papoyo= new CPersonalDeApoyo(legajo,nombre,apellido,aniDeIngreso,puesto);
                                hospital.AgregarEmpleado(Papoyo);
                                break;
                        }
                        
                        break;
                    case '3':
                                Console.WriteLine("\n -----------    LISTA DE LOS EMPLEADOS DEL HOSPITAL ");
                                
                                Console.WriteLine(hospital.EmpleadosDelHospital());
                                Console.ReadLine();
                        break;
                    case '4':
                        codigo = interfaz.DevlverUnString("Ingrese el Codigo del Servicio");
                        NombreDelServicio = interfaz.DevlverUnString("Ingrese el Nombre del Servicio");
                        legajo = interfaz.DevolverUnUint("Ingrese el Legajo de JEFE de Servicio");
                        CEmpleado jefe=hospital.BuscarEmpleado(legajo);
                        CServicio SER;
                        if (jefe==null)
                        {
                            legajo = interfaz.DevolverUnUint("Ingrese el Legajo del Jefe de Servicio");
                            nombre = interfaz.DevlverUnString("Ingrese el Nombre del Jefe de Servicio");
                            apellido = interfaz.DevlverUnString("Ingrese el Apellido del Jefe de Servicio");
                            aniDeIngreso = interfaz.DevolverUnUint("Ingrese el Año  de ingreso del Jefe de Servicio");
                            categoriaProfesional = interfaz.DevlverUnString("Ingrese la Categoria Profecional del Jefe de Servicio");
                            numeroDeMatricula = interfaz.DevolverUnUint("Ingrese el Numero de Matricula del Jefe de Servicio");
                            especialidad = interfaz.DevlverUnString("Ingrese la Especialidad del Jefe de Servicio");
                            jefe=new CMedico(legajo,nombre,apellido,aniDeIngreso,categoriaProfesional,numeroDeMatricula,especialidad,NombreDelServicio);
                            SER = new CServicio(codigo, nombre, jefe);
                            hospital.AgregarServicio(SER);
                        }

                        if(jefe is CMedico)
                        {
                            SER = new CServicio(codigo, NombreDelServicio, jefe);
                            hospital.AgregarServicio(SER);
                        }
                        
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                }

            }while (opcion != '0');
        }
    }
}
