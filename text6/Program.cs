using System;

class Program
{
    static void Main()
    {
        double sahe;
        double perimetr;
        Console.WriteLine("Esas Menyu: Secim edin\n1. Sahenin hesablanmasi\n2. Perimetr hesablanmasi\n3. Cixis\n");

        while (true)
        {
            string secim = Console.ReadLine(); // esas menyudaki secimi etmek ucun

            if (secim == "1" || secim == "2")
            {
                Console.WriteLine("Fiqur Secimi edin:\n1. Kvadrat\n2. Duzbucaqli\n3. Ucbucaq\n4. Cevre\n");
                string fiqur = Console.ReadLine(); // fiquru secmek ucun

                while (true)
                {
                    if (fiqur == "1")
                    {
                        Console.WriteLine("Kvadratin terefini daxil edin\n");
                        double teref = double.Parse(Console.ReadLine());

                        if (secim == "1")
                        {
                            sahe = teref * teref;
                            Console.WriteLine("Kvadratin Sahesi: ");
                            Console.WriteLine(sahe);
                        }
                        else
                        {
                            perimetr = teref * 4;
                            Console.WriteLine("Kvadratin Perimetri: ");
                            Console.WriteLine(perimetr);
                        }
                        break;
                    }
                    else if (fiqur == "2")
                    {
                        Console.WriteLine("Duzbucaqlinin tereflerini daxil edin\n");
                        double teref1 = double.Parse(Console.ReadLine());
                        double teref2 = double.Parse(Console.ReadLine());

                        if (secim == "1")
                        {
                            sahe = teref1 * teref2;
                            Console.WriteLine("Duzbucaqlinin Sahesi: ");
                            Console.WriteLine(sahe);
                        }
                        else
                        {
                            perimetr = teref1 * 2 + teref2 * 2;
                            Console.WriteLine("Duzbucaqlinin Perimetri: ");
                            Console.WriteLine(perimetr);
                        }
                        break;
                    }
                    else if (fiqur == "3")
                    {
                        Console.WriteLine("Ucbucagin tereflerini daxil edin\n");
                        double teref1 = double.Parse(Console.ReadLine());
                        double teref2 = double.Parse(Console.ReadLine());
                        double teref3 = double.Parse(Console.ReadLine());

                        if (secim == "1")
                        {
                            double s = (teref1 + teref2 + teref3) / 2;
                            sahe = Math.Sqrt(s * (s - teref1) * (s - teref2) * (s - teref3));
                            Console.WriteLine("Ucbucagin Sahesi: ");
                            Console.WriteLine(sahe);
                        }
                        else
                        {
                            perimetr = teref1 + teref2 + teref3;
                            Console.WriteLine("Ucbucagin Perimetri: ");
                            Console.WriteLine(perimetr);
                        }
                        break;
                    }
                    else if (fiqur == "4")
                    {
                        Console.WriteLine("Cevrenin radiusunu daxil edin\n");
                        double radius = double.Parse(Console.ReadLine());

                        if (secim == "1")
                        {
                            sahe = radius * 3.14 * 3.14;
                            Console.WriteLine("Cevrenin Sahesi: ");
                            Console.WriteLine(sahe);
                        }
                        else
                        {
                            perimetr = 2 * 3.14 * radius;
                            Console.WriteLine("Cevrenin uzunlugu: ");
                            Console.WriteLine(perimetr);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun Secim Edin\n");
                    }
                }
                break;
            }
            else if (secim == "3")
            {
                Console.WriteLine("3. Cixishi Secdiniz Proqram Dayandirildi\n");
                break; // 3cu bend secildiyi ucun chixish edilir
            }
            else
            {
                Console.WriteLine("Xahis edirik duzgun secim edin\n");

            }
        }
    }
}