using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEvaluacion
{
    class Program
    {
        static List<Candidato> candidatos = new List<Candidato>();
        static List<Votar> votos = new List<Votar>();
        static List<Votante> votantes = new List<Votante>();

        static void Main(string[] args)
        {
                       

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*******************Menu******************\n" +
                   "\n 1.Registrar Candidato" +
                   "\n 2.Vota" +
                   "\n 3.Cerrar Elecciones" +
                   "\n 4.Salir\n");

                Console.WriteLine("Selecciona el número : ");
                var MenuOption = Convert.ToInt32(Console.ReadLine());

                switch (MenuOption)
                {
                    case 1:
                        {
                            MenuOpcion1();
                        }
                        break;

                    case 2:
                        {
                            MenuOpcion2();
                        }
                        break;

                   /* case 3:
                        {
                            MenuOpcion3();
                        }
                        break;*/

                    case 4:
                        Console.Clear();
                        Console.Write("Gracias que tenga un excelente día");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;


                }

                

            }
        
        

        }

        private static void MenuOpcion1()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Escribe el ID del candidato: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe el nombre del candidato: ");
                string nombre = Console.ReadLine();

                Candidato candidato = new Candidato(id, nombre);
                candidatos.Add(candidato);

                Console.WriteLine("¿Desea agregar otro candidato? [y/n]");
                var option = Console.ReadLine();

                if (option == "n")
                {
                    break;
                }
            }

        }

        private static void MenuOpcion2()
        {
            Console.Clear();

            while (true)
            {

                Console.WriteLine("");
                Console.WriteLine("Elige el numero de candidato por el que deseas votar.");

                foreach (var candidate in candidatos)
                {
                    Console.WriteLine(candidate.Id + " " + candidate.Nombre);
                }
                Console.WriteLine("");

                Console.WriteLine("Ingresa tu ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu genero: ");
                string genero = Console.ReadLine();

                Votante votante = new Votante(id, nombre, edad, genero);
                votantes.Add(votante);

                Console.WriteLine("Elige el numero de candidato por el que deseas votar: ");
                int voto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Desea agregar otro voto? [y/n] ");
                var option = Console.ReadLine();

                Votar votar = new Votar(voto);
                votos.Add(votar);

                if (option == "n")
                {
                    break;
                }

            }

        }

        /*private static void MenuOpcion3()
        {
            Console.Clear();

            while (true)
            {
                foreach (var candidato in candidatos)
                {
                    int totalVotos = 0;

                    foreach (var voto in votos)
                    {
                        if (candidato.Id == voto.Voto)
                        {
                            int totalVotos = totalVotos + 1;
                            totalVotos = totalVotos;
                        }
                    }
                    totalVotos.Add(candidato.Id, totalVotos);
                }
                
                Console.WriteLine(" ");

                foreach (KeyValuePair<int, int> result in totalVotos.OrderByDescending(p => p.Value))
                {

                    foreach (var candidato in candidatos)
                    {
                        StringBuilder completo = new StringBuilder();

                        if (candidato.Id == result.Key)
                        {
                            for (int i = 1; i <= result.Value; i++)
                            {
                                completo.Append(" ");
                            }
                            var first = totalVotos.OrderByDescending(kvp => kvp.Value).First();
                            if (first.Value == result.Value)
                            {
                                Console.WriteLine("El ganador es: ");
                            }
                            Console.WriteLine("Candidato " + candidato.Nombre + ": " + completo + " " + result.Value + " votos." + Environment.NewLine);
                        }
                    }
                }

            }
        }*/
       


    }




}