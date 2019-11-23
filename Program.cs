using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    //Lo que queriamos hacer en este programa es evitar que el usuario ingrese datos erroneos, se captura una lista y si capturo un dato incorrectamente 
    //se le manda un msj con el error
    //Esto nos podria servir cuando solo necesitamos un tipo de dato para que el usuario no ingrese datos correctos o evitar que
    //se ingresen datos incorrectos al sistema
    class Program
    {
        static void Main(string[] args)
        {
            
            var estudiantes = new List<Estudiante>(); //Se crea una lista para capturar los estudiantes
            var agregar = true;
            var e = new Estudiante();

            while (agregar) 
            {

                try //Se declara un try para el error
                {

                    Console.WriteLine("INGRESE SU NUMERO DE CONTROL:"); //Se le pide al usuario que ingrese los sig datos
                    int NC = 0;
                    bool result;
                    result = int.TryParse(Console.ReadLine(), out NC); // Se utiliza para ver sin el usuario ingreso un valor incorrecto

                    if (result == false)
                    {
                        Console.WriteLine("INGRESE SOLO NUMEROS POR FAVOR TKM CUIDATE"); //Se le manda un msj al usuario si ingreso un dato incorrecto
                    }



                    Console.WriteLine();
                    Console.WriteLine("INGRESE SU NOMBRE:");
                    e.Nombre = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("INGRESE SU CARRERA:");
                    e.Carrera = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("INGRESE EL SEMESTRE QUE CURSA:");
                    e.Semestre = Console.ReadLine();
                    estudiantes.Add(e);
                    Console.WriteLine("DESEA AGREGAR OTRO USUARIO?  Y/N");
                    if (Console.ReadLine() != "y") //Si los datos estan correctos te pregunta si quieres hacer otra lista

                    {
                        agregar = false;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR AGREGANDO USUARIO"); //Se le manda este msj al usuario si ingreso mal los datos
                }


            }
            Console.ReadKey();
            
          
        }
    }
}
