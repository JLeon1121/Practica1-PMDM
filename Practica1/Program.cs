using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args) {
            List<Lienzo> lienzos = new List<Lienzo>();
            Lienzo lienzoActivo;
            int opcion = 0;
            do
            {
                //MENU
                Console.WriteLine("----- MENU -----" +
                    "\n 1. Crear lienzo en blanco" +
                    "\n 2.Cargar lienzo" +
                    "\n 3.Cambiar lienzo" +
                    "\n 4.Añadir cuadrado" +
                    "\n 5.Añadir círculo" +
                    "\n 6.Mostrar figuras" +
                    "\n 7.Desplazar" +
                    "\n 8.Salir " +
                    "\n-----------------");
                Console.Write("Elija una opción: ");
                var intro = Console.ReadLine();
                int.TryParse(intro, out opcion);
                int cont = 1;
                switch (opcion)
                {
                    case 1:
                        Lienzo li = new Lienzo();
                        Console.Write("Introduzca el nombre del nuevo lienzo: ");
                        li.Nombre = Console.ReadLine();
                        Console.Write("Introduzca el ancho del lienzo: ");
                        li.Ancho = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introduzca la altura del lienzo: ");
                        li.Alto = Convert.ToDouble(Console.ReadLine());
                        lienzos.Add(li);
                        lienzoActivo = li;
                        break;
                    case 2:
                        break;
                    case 3:
                        for (int i = 0; i < lienzos.Count; i++)
                        {
                            Console.WriteLine(cont + " " + lienzos[i].Nombre);
                            cont++;
                        }
                        Console.Write("Seleccione un lienzo: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        lienzoActivo = lienzos[num - 1];
                        Console.WriteLine("El lienzo que se encuntra activo es: " +lienzoActivo.Nombre);

                        break;
                    case 4:

                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Introduzca un número del 1 al 8\n");
                        break;
                } 
            }while (opcion != 8);
            }
        }
    }

