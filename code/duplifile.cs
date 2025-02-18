using System;

public class VeriIsleme
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
        if (b == 0)
        {
            throw new ArgumentException("Bölen sıfır olamaz.");
        }
        return a / b;
    }
}

public class Raporlama
{
    public void RaporOlustur(int sonuc, string islem)
    {
        Console.WriteLine($"{islem} işlemi sonucu: {sonuc}");
    }
}

public class Uygulama1
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 10;
        int sayi2 = 5;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Uygulama2
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 20;
        int sayi2 = 10;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
using System;

public class VeriIsleme
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
        if (b == 0)
        {
            throw new ArgumentException("Bölen sıfır olamaz.");
        }
        return a / b;
    }
}

public class Raporlama
{
    public void RaporOlustur(int sonuc, string islem)
    {
        Console.WriteLine($"{islem} işlemi sonucu: {sonuc}");
    }
}

public class Uygulama1
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 10;
        int sayi2 = 5;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Uygulama2
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 20;
        int sayi2 = 10;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
using System;

public class VeriIsleme
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
        if (b == 0)
        {
            throw new ArgumentException("Bölen sıfır olamaz.");
        }
        return a / b;
    }
}

public class Raporlama
{
    public void RaporOlustur(int sonuc, string islem)
    {
        Console.WriteLine($"{islem} işlemi sonucu: {sonuc}");
    }
}

public class Uygulama1
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 10;
        int sayi2 = 5;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Uygulama2
{
    public static void Main(string[] args)
    {
        VeriIsleme veriIsleme = new VeriIsleme();
        Raporlama raporlama = new Raporlama();

        int sayi1 = 20;
        int sayi2 = 10;

        // Tekrar eden kod bloğu 1: Toplama işlemi
        int toplam = veriIsleme.Topla(sayi1, sayi2);
        raporlama.RaporOlustur(toplam, "Toplama");

        // Tekrar eden kod bloğu 2: Çıkarma işlemi
        int fark = veriIsleme.Cikar(sayi1, sayi2);
        raporlama.RaporOlustur(fark, "Çıkarma");

        // Tekrar eden kod bloğu 3: Çarpma işlemi
        int carpim = veriIsleme.Carp(sayi1, sayi2);
        raporlama.RaporOlustur(carpim, "Çarpma");

        // Tekrar eden kod bloğu 4: Bölme işlemi
        try
        {
            int bolum = veriIsleme.Bol(sayi1, sayi2);
            raporlama.RaporOlustur(bolum, "Bölme");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
// C# duplicated code example
using System;
using System.Collections.Generic;

class Program
{
    static List<int> ProcessData(List<int> data)
    {
        List<int> result = new List<int>();
        foreach (var item in data)
        {
            if (item % 2 == 0)
            {
                result.Add(item * 2);
            }
            else
            {
                result.Add(item + 1);
            }
        }
        return result;
    }

    // Duplicate function
    static List<int> ProcessDataCopy(List<int> data)
    {
        List<int> result = new List<int>();
        foreach (var item in data)
        {
            if (item % 2 == 0)
            {
                result.Add(item * 2);
            }
            else
            {
                result.Add(item + 1);
            }
        }
        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4 };
        List<int> processedNumbers = ProcessData(numbers);
        Console.WriteLine(string.Join(", ", processedNumbers));
    }
}
