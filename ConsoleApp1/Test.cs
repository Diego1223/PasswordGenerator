


///*
// * Programa que calcule el minimo comun multiple
// */

///*
// * Nociones basicas
// * Dividir
// * Multiplicar
// * No se aceptan valores con punto
// * Multiplicar todos los valores encontrados al final
// * 
// * mcm(25, 75) = 75
// * 
// *  25 75 | 3
// *  25 75 | 5
// *  25 25 | 5
// *  5   5 |
// *  1   1 |
// */
//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {

//        static void Main(String[] args)
//        {
//            //Numeros primos = 2, 3, 5, 7

//            Dividir("25", 2);

//            Console.ReadKey();
//        }

//        static void Dividir(string valor, int dividirPor)
//        {
//            char[] recorrer;
//            bool entero = true;
//            double aux = 0;
//            string n1;

//            n1 = valor;
//            aux = Convert.ToDouble(n1);
//            aux = aux / dividirPor;

//            n1 = Convert.ToString(aux);
//            recorrer = n1.ToCharArray();

//            for (int i = 0; i < 4; i++)
//            {
//                if (recorrer[i] == '.')
//                {
//                    entero = false;
//                }
//            }

//            if (entero)
//            {
//                Convert.ToInt32(n1);
//                Console.WriteLine("Es un numero entero.");
//            }
//            else
//            {
//                Convert.ToDouble(n1);
//            }
//        }
//    }
//}