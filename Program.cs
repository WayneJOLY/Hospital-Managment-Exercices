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

             float bonoMedico, bonoEnfermero, bonoTecnico;

            Random rand = new Random();

            

            string opcion;
                char eleccion;
            
            CInterfaz interfaz= new CInterfaz();
            CHospital hospital= new CHospital();


            float MONTO = 8000000;
            CEmpleado.setMonto(MONTO);



            do
            {
                //char.Parse()
                opcion =interfaz.MostrarOpcion();

                switch (opcion)
                {
                    case "1":
                        break;
                    case "2":
                            Console.WriteLine("Agregar Un Empleado");

                        legajo = (uint)rand.Next(1500, 60796);       //interfaz.DevolverUnUint("Ingrese el Legajo de Empleado");
                        nombre = GenerarNombreAleatorio();     //interfaz.DevlverUnString("Ingrese el Nombre de Empleado");
                        apellido = GenerarApellidoAleatorio();   //interfaz.DevlverUnString("Ingrese el Apellido de Empleado");
                        aniDeIngreso = (uint)rand.Next(1970, 2024); //interfaz.DevolverUnUint("Ingrese el Año  de ingreso del Empleado");

                            Console.WriteLine("\n QUÉ TIPO DE EMPLEADO QUIERE REGISTRAR ? \n [A] Personal de Sanidad \n [B] Personal de Apoyo ");
                        eleccion = char.Parse(Console.ReadLine());
                        
                        switch (eleccion)
                        {
                            case'A' :
                                categoriaProfesional = GenerarCategoriaProfecionalAleatorio(); //interfaz.DevlverUnString("Ingrese la Categoria Profecional");
                                numeroDeMatricula = (uint)rand.Next(190000, 900000); //interfaz.DevolverUnUint("Ingrese el Numero de Matricula");
                                CPersonalDeSanidad sanidad= new CPersonalDeSanidad(legajo,nombre,apellido,aniDeIngreso,categoriaProfesional,numeroDeMatricula);
                                sanidad.SetBono(15000);
                                hospital.AgregarEmpleado(sanidad);

                                /*-------------------------------------------------------------------*/
                               // switch(true)
                               // {
                               //     case "1":  //Enfermero
                               //         break;
                               //     case "2":  //TECNICO
                               //         break;
                               //     case "3":  //MEDICO
                               //         break;
                               // }

                                /*-------------------------------------------------------------------*/

                                break;
                            case 'B':
                                puesto = GenerarPuesto(); //interfaz.DevlverUnString("Ingrese el puesto de Empleado");
                                CPersonalDeApoyo Papoyo= new CPersonalDeApoyo(legajo,nombre,apellido,aniDeIngreso,puesto);
                                hospital.AgregarEmpleado(Papoyo);
                                break;
                        }
                        
                        break;
                    case "3":
                                Console.WriteLine("\n -----------    LISTA DE LOS EMPLEADOS DEL HOSPITAL ");
                                
                                Console.WriteLine(hospital.EmpleadosDelHospital());
                                Console.ReadLine();
                        break;
                    case "4":
                                    codigo = (rand.Next(1000, 90000)).ToString(); //interfaz.DevlverUnString("Ingrese el Codigo del Servicio");
                                    NombreDelServicio = GenerarNombreDeSercvicioAleatorio(); //interfaz.DevlverUnString("Ingrese el Nombre del Servicio");
                                    legajo = (uint)interfaz.DevolverUnUint("Ingrese el Legajo de JEFE de Servicio");
                                    CEmpleado jefe=hospital.BuscarEmpleado(legajo);
                                    CServicio SER;
                                    if (jefe==null)
                                    {
                                        legajo = (uint)rand.Next(1500, 60796);//interfaz.DevolverUnUint("Ingrese el Legajo del Jefe de Servicio");
                                        nombre = GenerarNombreAleatorio();//interfaz.DevlverUnString("Ingrese el Nombre del Jefe de Servicio");
                                        apellido = GenerarApellidoAleatorio(); //interfaz.DevlverUnString("Ingrese el Apellido del Jefe de Servicio");
                                        aniDeIngreso = (uint)rand.Next(1970, 2024); //interfaz.DevolverUnUint("Ingrese el Año  de ingreso del Jefe de Servicio");
                                        categoriaProfesional = GenerarCategoriaProfecional(); //interfaz.DevlverUnString("Ingrese la Categoria Profecional del Jefe de Servicio");
                                        numeroDeMatricula = (uint)rand.Next(10500, 60796); //interfaz.DevolverUnUint("Ingrese el Numero de Matricula del Jefe de Servicio");
                                        especialidad = GenerarEspecialidadMedicaProfecionalAleatorio(); //interfaz.DevlverUnString("Ingrese la Especialidad del Jefe de Servicio");
                                        jefe =new CMedico(legajo,nombre,apellido,aniDeIngreso,categoriaProfesional,numeroDeMatricula,especialidad,NombreDelServicio);
                                        SER = new CServicio(codigo, NombreDelServicio, (CMedico)jefe);
                                        hospital.AgregarServicio(SER);
                                        hospital.AgregarEmpleado(jefe);
                                    }

                                    //if(jefe is CMedico)
                                    //{
                                    //    SER = new CServicio(codigo, NombreDelServicio, (CMedico)jefe);
                                    //    hospital.AgregarServicio(SER);
                                    //}
                                    //else
                                    //{
                                    //    Console.WriteLine("El  JEFE DEBE OBLIGATORIAMENTE SER UN MEDICO");
                                    //}
                        break;
                    case "5":
                        legajo = (uint)interfaz.DevolverUnUint("Ingrese el Legajo de Empleado");
                        codigo = interfaz.DevlverUnString("Ingrese el Codigo Del Servicio");
                        CEmpleado empleado=hospital.BuscarEmpleado(legajo);
                        CServicio servicio = hospital.BuscarServicio(codigo);
                        hospital.AgregarEmpleadoAServicio(empleado, servicio);
                        break;
                    case "6":
                        codigo = interfaz.DevlverUnString("Ingrese el Codigo Del Servicio");
                        legajo = (uint)interfaz.DevolverUnUint("Ingrese el Legajo de Empleado");
                        empleado = hospital.BuscarEmpleado(legajo);
                        servicio = hospital.BuscarServicio(codigo);
                        if (empleado is CMedico && !empleado.ESTA_EN_UN_SERVIVCIO)
                        {
                            servicio.setJefe((CMedico) empleado);
                        }
                        break;

                    case "7":
                        codigo = interfaz.DevlverUnString("Ingrese el Codigo Del Servicio");
                        
                        servicio = hospital.BuscarServicio(codigo);
                        if(servicio!=null)
                        {
                            Console.WriteLine(servicio.ToString());
                        }
                        else
                        {
                            Console.WriteLine("\n NO SE ENCONTRO EL SERVICIO BUSCADO ");
                        }
                        Console.ReadKey();
                        break;
                    case "8":
                        legajo = (uint)interfaz.DevolverUnUint("Ingrese el Legajo de Empleado");
                        empleado = hospital.BuscarEmpleado(legajo);
                        if (empleado != null)
                        {
                            Console.WriteLine(empleado.ToString());
                            Console.WriteLine("\n Trabaja En Los siguientes Servicios {0} :", hospital.LOSSERVICIOSenLasCualesTrabaja(empleado.GetLegajo()));
                            Console.ReadKey();
                        }
                        break;
                    case "9":
                        legajo = (uint)interfaz.DevolverUnUint("Ingrese el Legajo de Empleado  A Eliminar");
                        empleado = hospital.BuscarEmpleado(legajo);
                        hospital.EliminarEmpleado(empleado);
                        break;

                    case "10":
                        break;

                    case "11":

                        Console.WriteLine("AGREGAR UN CONSULTORIO");
                        uint codig = (uint)rand.Next(150, 700);//(uint)interfaz.DevolverUnUint("Ingrese el Codico del Cosultorio");
                        uint piso = (uint)rand.Next(1, 11);//interfaz.DevolverUnUint("Ingrese el Piso del Cosultorio");
                        string sector = GenerarEspecialidadMedicaProfecionalAleatorio(); //interfaz.DevlverUnString("Ingrese el Sector del Cosultorio");
                        CConsultorio consultorio= new CConsultorio(codig, piso,sector);
                        hospital.AgregarConsultorio(consultorio);
                        break;

                    case "12":
                        
                        codig =  interfaz.DevolverUnUint("Ingrese el Codigo del Cosultorio");
                        string service = interfaz.DevlverUnString("Ingrese el Codigo del Servicio");
                        hospital.AsignarConsultorioASercicio(codig, service);
                        break;

                    case "13":
                         service = interfaz.DevlverUnString("Ingrese el Codigo del Servicio");      
                        CServicio ser= hospital.BuscarServicio(service);
                        if (ser != null)
                        {
                            Console.WriteLine(ser.ListaDelosConsultorios());
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No Se Encontro El Servicio buscado");
                        }
                        break;

                    case "14":
                        Console.WriteLine(hospital.ListaDeLosConsultoriosDelHospital());
                        Console.ReadKey();
                        break;
                    case "15":
                        Console.WriteLine("LISTA DE LOS SERVICIOS DEL HOSPITAL\n");
                        Console.WriteLine(hospital.ListaDeServiciosDelHospital());
                        Console.ReadKey();
                        break;
                }

            }while (opcion != "0");
        }






        static string GenerarNombreAleatorio()
        {
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Carlos", "Marta", "Javier", "Lucía" };
            Random rnd = new Random();
            return nombres[rnd.Next(nombres.Length)];
        }

        // Función para generar un apellido aleatorio
        static string GenerarApellidoAleatorio()
        {
            string[] apellidos = { "García", "Martínez", "López", "González", "Rodríguez", "Fernández", "Pérez", "Gómez", "Sánchez", "Díaz" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }

        static string GenerarCategoriaProfecional()
        {
            string[] apellidos = { "García", "Martínez", "López", "González", "Rodríguez", "Fernández", "Pérez", "Gómez", "Sánchez", "Díaz" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }

        static string GenerarPuesto()
        {
            string[] apellidos = { "Cordinador", "Gestion de Talento", "Gestión digital de documentación", "personal de limpieza", "personal demantenimiento", "Farmacéuticos", "Facturistas", "Contabilidad", "Informática y Sistemas", "Comunicación y Marketing" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }


        static string GenerarCategoriaProfecionalAleatorio()
        {
            string[] apellidos = { "Medico", "Enfermero", "Tecnico" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }

        static string GenerarEspecialidadMedicaProfecionalAleatorio()
        {
            string[] apellidos = { "Guardia Medica", "Traumatologia", "Cirugia","Pediatria","Oncologia" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }
        static string GenerarEspecializacionEnfermeriaAleatorio()
        {
            string[] apellidos = { "Enfermeria General", "Terapista Intensivo", "Cirugia", "Pediatria", "Oncologia","Dermatologia", "Psiquiatría" };
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }
        static string GenerarNombreDeSercvicioAleatorio()
        {
            string[] apellidos = { "Emergencias", "Hospitalización", "Consulta Externa", "Quirófanos", "Unidad de Cuidados Intensivos", "Laboratorio Clínico", "Imágenes Médicas" };
            /*
             * 1. Emergencias
Atención inmediata para casos críticos y urgentes.
2. Consulta Externa
Consultas programadas con médicos especialistas.
3. Hospitalización
Servicios de internación para pacientes que requieren atención continua.
Servicios Quirúrgicos
4. Quirófanos
Realización de cirugías programadas y de emergencia.
5. Unidad de Cuidados Intensivos (UCI)
Atención especializada para pacientes en estado crítico.
Servicios Diagnósticos
6. Laboratorio Clínico
Análisis de muestras biológicas para diagnósticos.
7. Imágenes Médicas
Rayos X, ultrasonido, tomografía computarizada (TC), resonancia magnética (RM).
Servicios de Rehabilitación
8. Fisioterapia
Tratamientos para la recuperación física de los pacientes.
9. Terapia Ocupacional
Ayuda a los pacientes a recuperar habilidades para la vida diaria.
Servicios de Apoyo
10. Farmacia
Suministro de medicamentos y asesoramiento farmacéutico.
11. Nutrición y Dietética
Planificación de dietas adecuadas para pacientes.
12. Psicología y Salud Mental
Apoyo psicológico y psiquiátrico para pacientes.
Servicios Administrativos
13. Admisión y Registro
Proceso de ingreso de pacientes y gestión de datos.
14. Facturación
Gestión de costos y cobros por servicios médicos.
Servicios Especializados
15. Oncología
Tratamiento y manejo de pacientes con cáncer.
16. Pediatría
Atención médica especializada para niños.
17. Ginecología y Obstetricia
Atención de la salud reproductiva de mujeres y cuidado prenatal.
             * */
            Random rnd = new Random();
            return apellidos[rnd.Next(apellidos.Length)];
        }
    }
}
