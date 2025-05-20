// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("valor de a:" + a);

Console.WriteLine("valor de b:" + b);*/

// EJERCICIO 1
/*Console.WriteLine("Ingrese un numero entero positivo:");

string entrada = Console.ReadLine();

int numero;

double inverso;

if (int.TryParse(entrada, out numero))
{
    if (numero > 0)
    {
        inverso = (double)1 / numero;
        Console.WriteLine("El inverso del numero ingresado es:" + inverso);
    }
    else
    {
        Console.WriteLine("El numero no es mayor a 0");
    }
}
else
{
    Console.WriteLine("El dato ingresado no es un numero entero");
};*/

// EJERCICO 2
Console.WriteLine("CALCULADORA");

int oper = 1;
while (oper != 0)
{
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");

    Console.WriteLine("Ingrese su eleccion:");
    oper = Console.Read();

    if (oper != 0)
    {
        Console.WriteLine("Ingrese los numeros a analizar:");
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        decimal an;
        decimal bn;
        decimal resultado;

        if (decimal.TryParse(a, out an) && decimal.TryParse(b, out bn))
        {
            switch (oper)
            {
                case 1:
                    resultado = an + bn;
                    break;
                case 2:
                    resultado = an - bn;
                    break;
                case 3:
                    resultado = an + bn;
                    break;
                case 4:
                    resultado = an + bn;
                    break;
                default:
                    break;
            }
            
        }
        
    }

}


