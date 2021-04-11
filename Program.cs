using System;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            int numUno = 0;
            int numDos = 0;
            int ressuma;
            int resResta;
            int resMulti, resdiv;

     //solicitando numeros por consola//
      Console.WriteLine("Introduzca su primer numero");
          numUno=int.Parse(Console.ReadLine());
      Console.WriteLine("Introduzca su segundo numero");
          numDos=int.Parse(Console.ReadLine());

           ressuma = numUno + numDos;
           resResta = numUno - numDos;
           resMulti = numUno * numDos;
           resdiv = numUno / numDos;
      Console.WriteLine("La suma de los numeros es: " + ressuma);
      Console.WriteLine("La resta de los numeros es: " + resResta);
      Console.WriteLine("La multiplicación de los numeros es: " + resMulti);
      Console.WriteLine("La división de los numeros es: " + resdiv);
           //consoleRedline espera q usuario pulse tecla//
           Console.ReadLine();*/

//mayor de  dos numero//
 /*           int numUno = 0;
            int numDos = 0;

        Console.WriteLine("Introduzca su primer numero");
          numUno=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca su segundo numero");
          numDos=int.Parse(Console.ReadLine());
          if (numUno>numDos)
          {
                    Console.WriteLine("El numero: " + numUno+" es el mayor");
                    Console.Read();
          }
          else {
               Console.WriteLine("El numero: " + numDos+" es el mayor");
                    Console.Read();
          }*/

//menor de tres numeros
          /*int numUno = 0;
            int numDos = 0;
            int numTres = 0;

        Console.WriteLine("Introduzca su primer numero");
          numUno=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca su segundo numero");
          numDos=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca su tercer numero");
          numTres=int.Parse(Console.ReadLine());
  
          if ( numUno<numDos)
          {
                    if(numUno<numTres)
                    {
                         Console.WriteLine("El numero: " + numUno+" es el menor de los ingresados");
                         Console.Read();

                    }
          }
          if (numDos<numUno)
          {
                    if(numDos<numTres)
                    {
                         Console.WriteLine("El numero: " + numDos+" es el menor de los ingresados");
                         Console.Read();
                    }
          }
          if (numTres<numDos)
          {
                 if(numTres < numUno)
                    {
                         Console.WriteLine("El numero: " + numTres+" es el menor de los ingresados");
                         Console.Read();
                    }
          }*/

    //numero par o impar
    /*
        int numUno = 0;
        Console.WriteLine("Introduzca su primer numero");
        numUno=int.Parse(Console.ReadLine());
        //mod en c# es % asignar == para resultado
        if(numUno % 2 == 0)
        {
            Console.WriteLine("El numero: " + numUno +" es par");
                         Console.Read();
        }
        else
        {
             Console.WriteLine("El numero: " + numUno +" es impar");
                         Console.Read();
        }*/

        //cuadrado de un numero
       /* int numUno = 0;
        int resCuadrado = 0;
        Console.WriteLine("Introduzca su numero para calcular su cuadrado");
        numUno=int.Parse(Console.ReadLine());

        resCuadrado = numUno*numUno;
        Console.WriteLine("El cuadrado de numero ingresado es: " + resCuadrado);
        Console.Read();
        */

        //area del triangulo
/*
        float baseTriangulo = 0;
        float alturaTriangulo = 0;
        float areaTriangulo = 0;
        Console.WriteLine("Introduzca la base");
        baseTriangulo=float.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca la altura");
        alturaTriangulo=float.Parse(Console.ReadLine());

        areaTriangulo = (baseTriangulo*alturaTriangulo)/2;
        Console.WriteLine("El area del triangulo es: " + areaTriangulo);
                      Console.Read();*/

    //metros a centimetros 
        float metros = 0;
        int centimetros = 100;
        float resConver = 0;
        Console.WriteLine("Introduzca su valor en metros");
        metros=float.Parse(Console.ReadLine());

        resConver = metros*centimetros;
        Console.WriteLine(metros + "metros son:" + resConver+ "centimetros");
        Console.Read();
    }
    }
}

