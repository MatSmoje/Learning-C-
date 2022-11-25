using System;

namespace learn_main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string OutputMsg = ""; 
            Character Aresden = new Character("Mat[GM]");
            GameConsole PlayerConsole = new GameConsole(Aresden);
            while (1 == 1)
            {
                PlayerConsole.Interface(OutputMsg);
                OutputMsg = PlayerConsole.GetCommand();
                //OutputMsg = ConsoleGame(Aresden);

            }
            Console.Read();
            // int numero_a_int = Int32.Parse(numero) + Int32.Parse(numero2);
            //Console.WriteLine(numero_a_int);

            // Conversion explicita
            /*
            double miFloat = 32.123;
            int miInt;
            
            miInt = (int) miFloat;
            Console.WriteLine(miInt);
            // Conversion implicita
            int numeroFloat = 13;
            double doubleVar = numeroFloat;
            string stringVar = numeroFloat.ToString();
            */

            /*METODOS DE STRING }
             * SubString(1)
             * ToLower()
             * ToUpper()
             * Trim() -> borrar espacios blancos: iniciales y finales
             * IndexOf(string) -> obtener indice de primera aparicion de caracter en un string
             * IsNullOrWhiteSpace() -> devuelve true si string esta en blanco o es null
             * string.Concat("",var1,var3,"")
           */




            //nombre = "Matias Smoje";
            //Console.WriteLine("Hola Mundo {0}", nombre);

        }
        public static string ConsoleGame(Character name)
        {
            string command;
            string output = ""; 

            Console.Write("$ ");
            command = Console.ReadLine();
            string[] commandSplited = command.Split(' ');

            if ((commandSplited[0] == "experience") || (commandSplited[0] == "exp"))
            {
                if (commandSplited.Length == 1)
                {
                    output = $"Help command experience: \n" +
                        $"Usage: $ experience -arg1 -arg2 \n" +
                        $"Arguments: -assign or -a [int]  : Assign exp";
                }
                else if (commandSplited.Length == 2)
                {
                    bool expBool = int.TryParse(commandSplited[1], out int amount);
                    if (expBool)
                    {
                        name.GainExperience(amount);
                        output = $"{amount} Experience assigned";
                    }
                    else
                    {
                        output = $"You must insert a number arg.";
                    }
                }
                else
                {
                    output = $"You have added more args than necessary";
                }
                //output = commandSplited.Length.ToString(); 
            }
            else if (commandSplited[0] == "stat")
            {
                if (commandSplited.Length == 1)
                {
                    output = $"Help command experience: \n" +
                        $"Usage: $ stat -arg1\n" +
                        $"Arguments: -assign or -a [int]  : Assign exp";
                }
                else if (commandSplited.Length == 2)
                {
                    if ((commandSplited[1] == "-str") || (commandSplited[1] == "-dex") ||
                        (commandSplited[1] == "-int") || (commandSplited[1] == "-mag") ||
                        (commandSplited[1] == "-vit") || (commandSplited[1] == "-chr"))
                        output = $"You must insert a number arg.";
                    else
                        output = $"Incorrect argument";
                }
                else if (commandSplited.Length == 3)
                {
                    if (commandSplited[1] == "-str") output = $"{commandSplited[2]} str";
                    else if (commandSplited[1] == "-dex") output = $"{commandSplited[2]} dex";
                    else if (commandSplited[1] == "-int") output = $"{commandSplited[2]} int";
                    else if (commandSplited[1] == "-mag") output = $"{commandSplited[2]} mag";
                    else if (commandSplited[1] == "-vit") output = $"{commandSplited[2]} vit";
                    else if (commandSplited[1] == "-chr") output = $"{commandSplited[2]} chr";
                    else output = $"You must insert a number arg.";
                }
                //name.AddStat()
                Console.WriteLine("test");
            }
            else
            {
                output = $"{commandSplited[0]}: Wrong Command";
            }
                /*(commandSplited[1] == "-assign" || commandSplited[1] == "-a"))
            {
                bool expBool = int.TryParse(commandSplited[2], out int amount);

                if (expBool)
                {
                    name.GainExperience(amount);
                }
                output = $"{amount} Experience assigned";
            }
            else output = "Error: Command doesn't exist";*/
            
            //Console.Read();
            return output;
        }
            

        

        public static void ClaseTresCondicionales()
        {
            /*
             * if, if en una linea
             * switch(){ case 1: default:}
             * TryParse
             * if ternario 
             */
            int temperatura = 10;
            string estadoAgua = temperatura < 0 ? "Hielo" : temperatura < 100 ? "Liquido" : temperatura >= 100 ? "Gas" : "NADA";
            Console.WriteLine(estadoAgua);
            temperatura = -41;
            estadoAgua = temperatura < 0 ? "Hielo" : temperatura < 100 ? "Liquido" : temperatura >= 100 ? "Gas" : "NADA";
            Console.WriteLine(estadoAgua);
            temperatura = 141;
            estadoAgua = temperatura < 0 ? "Hielo" : temperatura < 100 ? "Liquido" : temperatura >= 100 ? "Gas" : "NADA";
            Console.WriteLine(estadoAgua);

        }
        public static void ClaseCuatroLoops()
        {
            /*
             * for(inicial; condicion; incremento)
             * while (condicion)
             * do (...) while (condicion) : tendremos al menos 1 ejecución
             * for each: para recorrer arrays
             * break y continuo
             */

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int i = 0;
            do
            {
                Console.WriteLine($"Hola Matías {i}");
                i++;
            }
            while (i < 20);
            */
            /*
            string textoIngresado = "";
            while (textoIngresado.Equals(""))
            {
                Console.WriteLine("Hola");
                textoIngresado = Console.ReadLine();
                
            }
            */
            // Break + Continue 
            // Con continue nos saltamos lo que ivene de la iteración :) 
            for (int i = 0; i < 10; i++)
            {

                if (i == 3) continue;
                Console.WriteLine(i);
            }


        }

        public static void ClaseSieteArrays()
        {
            // Definicion
            int[,] edadesCurso = new int[10, 10];
            int[,] edadesCurso2 = { { 1, 2 }, { 3, 4 } };

            // Obtener cantidades de dimensiones
            int dimension = edadesCurso.Rank;
            Console.WriteLine(dimension);


        }

        public static void ClaseOchoArrays()
        {
            /**
             * 1. Arrays Irregulares
             * 2. ArrayList
             * 3.
             * 4.
             * 5.
             **/

            // 1. Arrays Irregulares - 1ra declaracion
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            irregular[0] = new int[] { 2, 3, 8, 9, 11 };
            irregular[1] = new int[] { 2, 3, 120 };
            irregular[2] = new int[] { 222, 22 };

            // 1. Arrays Irregulares - 2da declaracion
            int[][] irregular2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5, 6, },
                new int[] { 1, 100, 3 },
                new int[] { 1, 88 },
                new int[] { 1, 2, 1, 12, 3, 21, 43, 342 }
            };

            // 2. ArrayLists

            // 3. Listas (Crecen dinamicamente)
            /* se debe agregar namespace -> System.Collections.Generic
             * ar nmeros = new List<int>{1,2,6,4}
             * nmeros.Add(7);
             * nmeros.Remove(7);
             * nmeros.RemoveAt(indice);
             * nmeros.Clear(); vacia lista
             * funcina con for y foreach
             * nmeros.Sort();
             * nmeros.Contains(4);
             * nmeros.FindIndex(x=> x==4);
             * 
             * 
             * *********ArrayLists**************
             * 
             * System.Collections.ArrayList arr1= new System.Collections.ArrayList();
             * arr1.Add(1);
             * arr1.Add("asd");
             * arr1.Add("1");
             * arr1.Add(new numero { n = 4}); //Objeto de clase
             */

        }
    }
}

