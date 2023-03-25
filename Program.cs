using System;
using System.Diagnostics.Metrics;

void adivina()
{

    const int oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte intentos, BanderaControl;
    string linea;

    Random rand = new Random();

    do
    {
        numeroCPU = Convert.ToInt32(rand.Next(100));
        Console.WriteLine(numeroCPU);
    }

    while (!(((numeroCPU >= 1) & (numeroCPU <= 20))));

    intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Hola estoy pensando en un numero. Cual crees que es?");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if ((numeroUsuario == numeroCPU))
        {
            Console.WriteLine("Como lo Supiste??? Felicidades.");
            BanderaControl = 1;
        }
        else
        {
            if (numeroUsuario > numeroCPU)
            {
                Console.WriteLine("Sigue Intentando");
            }
        }
        intentos++;
    }

    while (((intentos <= oportunidades) & (BanderaControl == 0)));

    if (BanderaControl == 0)
    {
        Console.WriteLine("El numero que pense era:" + numeroCPU);
    }
}


void BuscaMayor()
{
    int Mayor = 0;
    int Numero = 0;
    Random numerito = new Random();

    for (int i = 0; i < 5; i++)
    {
        Numero = numerito.Next(100);
        Console.WriteLine(Numero);
        if (Numero > Mayor)
        {
            Mayor = Numero;
        }
    }
    Console.WriteLine("El numero Mayor es:" + Mayor);
}

void BuscaMenor()
{
    int Menor = 100;
    int Numero = 0;
    Random numerito = new Random();

    for (int i = 0; i < 5; i++)
    {
        Numero = numerito.Next(100);
        Console.WriteLine(Numero);
        if (Numero < Menor)
        {
            Menor = Numero;
        }
    }
    Console.WriteLine("El numero menor es:" + Menor);
}

void arreglos()
{
    int[] notas = new int[4];
    Random rnd = new Random();
    Console.WriteLine("Esta Cargando Informacion");

    for (int i = 0; i < notas.Length;i++)
    {
        notas[i] = rnd.Next(100);
    }

    Console.WriteLine("Desplegando Informacion");

    int mayor = 0;
    int menor = 0;
    int promedio = 0;

    for (int i = 0;i < notas.Length;i++)
    {
        Console.WriteLine(notas[i]);
    }

    Console.WriteLine("Nota Mayor =" + mayor);

}

void nombres()
{
    string[] nombre = new string[11];
    nombre[0] = "Madelin";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Rodrigo";
    nombre[7] = "Brayan";
    nombre[8] = "Elder";
    nombre[9] = "Jairo";
    nombre[10] = "Brenda";

    Random generador = new Random();
    int ganador1 = generador.Next(0, nombre.Length);
    Console.WriteLine("El Cerdo Sin Una Pierna Es Para:" + nombre[ganador1]);
    int ganador2 = generador.Next(0, nombre.Length);
    Console.WriteLine("La Pierna Es Para:" + nombre[ganador2]);
 
    for (int i = 0; i < nombre.Length; i++)

    {
        Console.WriteLine(i+": " + nombre[i]);
    }


 }

//adivina();
//BuscaMayor();
//BuscaMenor();
//arreglos();
//nombres();