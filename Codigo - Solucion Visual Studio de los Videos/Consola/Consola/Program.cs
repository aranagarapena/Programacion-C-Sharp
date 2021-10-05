using Biblioteca;
using Consola.Clases;
using System;
using System.Collections.Generic;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //// -------------- DOCUMENTACION ------------------------------
            //// https://docs.microsoft.com/es-es/dotnet/csharp/
            //// https://www.w3schools.com/cs/index.php



            //// ------------------ 1. TIPOS DE DATOS ----------------------------------

            //// 1.1 Tipos de datos PRIMITIVOS

            //// 1.1.1 Tipo numericos

            //// Entero -2.147.483.648 a -2.147.483.647
            //int entero = int.MaxValue;

            //// Real de coma flotante de 32 bits de precision --> -3.402823e38 a 3.402823e38
            //float comaFlotante = float.MaxValue;

            //// Real de coma flotante de 64 bits de precision --> -1.79769313486232e308 to 1.79769313486232e308
            //double real = double.MaxValue;

            //// 1.1.2 Tipo Texto

            //// caracter Unicode de 16 bits
            //char caracter = char.MaxValue;

            //// cualquier secuencia de texto Unicode
            //string cadenaTexto = string.Empty;

            //// 1.1.3 Tipo Logico

            //// booleano 8 bits - True o False
            //bool booleano = false;

            //// entero de 8 bits --> 0 a 255
            //byte b = byte.MaxValue;


            //// ------------------ 2. MODIFICADORES DE ACCESO ----------------------------------

            //// 2.1 Public y Private

            //Clases.Coche coche1 = new Clases.Coche();
            //Console.WriteLine(coche1.VelocidadCoche());

            //// 2.2 Internal

            //Biblioteca.Coche coche = new Biblioteca.Coche();
            //Console.WriteLine(coche.DevolverModelo());


            //// ------------------ 3. Clase ESTATICA ----------------------------------

            //// 3.1 clase estatica creadas por nosotros
            //Console.WriteLine(Biblioteca.OperacionesEstaticas.CalcularCuadrado(2));
            //Console.WriteLine(Biblioteca.OperacionesEstaticas.CalcularSuma(2, 5));


            //// 3.2 Clases estaticas nativas

            //// 3.2.1 Math
            //Console.WriteLine(Math.Min(5, 7));
            //Console.WriteLine(Math.Sqrt(8));
            //Console.WriteLine(Math.Abs(-8.7));
            //Console.WriteLine(Math.Round(9.99));

            //// 3.2.2 DateTime

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.DaysInMonth(1991, 2));



            //// ------------------ 4. ABSTRACCION ----------------------------------

            //// 3.1 Clase Abstracta
            //Pajaro p = new Pajaro();
            //Console.WriteLine(p.sonidoAnimal());


            //// 3.2 Interfaz
            //Gato g = new Gato();
            //Console.WriteLine(g.sonidoAnimal());



            //// ------------------ 5. ESTRUCTURAS DE DATOS ----------------------------------

            //// 4.1 Enumeradores
            //EnumNivel nivelProgramacion = EnumNivel.ALTO;

            //// 4.2 Lista
            //List<double> listaReales = new List<double>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Random r = new Random();
            //    listaReales.Add(r.NextDouble());
            //}

            //foreach (double num in listaReales)
            //{

            //    Console.WriteLine(num);

            //}


            //// 4.3 Tupla

            //List<Tuple<int, double>> listaTuplas = new List<Tuple<int, double>>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Random r = new Random();
            //    listaTuplas.Add(new Tuple<int, double>(i, r.NextDouble()));
            //}


            //// 4.4 Diccionario
            //Dictionary<string, string> abrirCon = new Dictionary<string, string>();
            //abrirCon.Add(".txt","notepad++");
            //abrirCon.Add(".csv", "Sublime text");
            ;


            // ------------------ 6. GESTION DE EXCEPCIONES ----------------------------------

            //try
            //{
            //    int x = 300;
            //    int y = 0;
            //    int z = x / y;
            //}
            //catch (Exception e) {

            //    // gestion de la excepcion
            //    Console.WriteLine(e.Message);


            //}

            //finally {

            //    // siempre se ejecuta
            //    Console.WriteLine("Programa acabado");
            //}


            // ------------------ 7. GESTION DE FICHEROS ----------------------------------

            //// 7.1 Escribir en un fichero
            //string escribir = "Kaixo! soy Iker Arana ............";

            //File.WriteAllText("fichero.txt", escribir);

            //// 7.2 Leer Fichero
            //string leer = File.ReadAllText("fichero.txt");
            //Console.WriteLine(leer);

            
        }
    }
}
