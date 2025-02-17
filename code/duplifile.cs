public class Hesaplayici
{
    public int Topla(int a, int b)
    {
        return a + b;
    }

    public int Cikar(int a, int b)
    {
        return a - b;
    }

    public int Carp(int a, int b)
    {
        return a * b;
    }

    public int Bol(int a, int b)
    {
        return a / b;
    }
}

public class GelismisHesaplayici
{
    public int Topla(int a, int b)
    {
        return a + b;
    }

    public int Cikar(int a, int b)
    {
        return a - b;
    }

    public int Carp(int a, int b)
    {
        return a * b;
    }

    public int Bol(int a, int b)
    {
        return a / b;
    }
}
using System;

public class DuplicateCodeExample1
{
    public void PrintSquare(int number)
    {
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);
    }

    public void PrintCube(int number)
    {
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }

    public void PrintSquareAndCube(int number)
    {
        // Tekrar eden kod: kare hesaplama
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);

        // Tekrar eden kod: küp hesaplama
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }
}

public class DuplicateCodeExample2
{
    public void PrintSquare(int number)
    {
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);
    }

    public void PrintCube(int number)
    {
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }

    public void PrintSquareAndCube(int number)
    {
        // Tekrar eden kod: kare hesaplama
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);

        // Tekrar eden kod: küp hesaplama
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }
}

public class DuplicateCodeExample3
{
    public void PrintSquare(int number)
    {
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);
    }

    public void PrintCube(int number)
    {
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }

    public void PrintSquareAndCube(int number)
    {
        // Tekrar eden kod: kare hesaplama
        int square = number * number;
        Console.WriteLine("The square of " + number + " is " + square);

        // Tekrar eden kod: küp hesaplama
        int cube = number * number * number;
        Console.WriteLine("The cube of " + number + " is " + cube);
    }
}
