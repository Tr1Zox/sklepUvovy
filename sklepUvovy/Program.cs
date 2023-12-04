using sklepUvovy;
using System.Data;

List<Produkt> produkty = new List<Produkt>();
List<Magazyn> magazyny = new List<Magazyn>();
while (true)
{
    Console.WriteLine("MENU");
    Console.WriteLine("Wybierz opcje:");
    Console.WriteLine("1. Dodaj/Edytuj/Usun Magazyn");
    Console.WriteLine("2. Dodaj/Edytuj/Usun Produkt");
    Console.WriteLine("3. Dodaj/Usun Produkt z Magazynu");
    Console.WriteLine("4. Wyjscie");
    string wybor = Console.ReadLine();
    switch (wybor)
    {
        case "1":
            Console.WriteLine("<MAGAZYN>");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Edytuj");
            Console.WriteLine("3. Usun");
            Console.WriteLine("4. Wyswietl magazyny");
            Console.WriteLine("5. Wyjscie");
            string wybor1 = Console.ReadLine();
            switch (wybor1)
            {
                case "1":
                    magazyn_dodaj(magazyny);
                    break;
                case "2":
                    magazyn_edytuj(magazyny);
                    break;
                case "3":
                    magazyn_usun(magazyny);
                    break;
                case "4":
                    magazyn_wyswietl(magazyny);
                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("źle");
                    break;
            }
            break;
        case "2":
            Console.WriteLine("PRODUKT");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Edytuj");
            Console.WriteLine("3. Usun");
            Console.WriteLine("4. Wyswietl produkty");
            Console.WriteLine("5. Wyjscie");
            string wybor2 = Console.ReadLine();
            switch (wybor2)
            {
                case "1":
                    produkt_dodaj(produkty);
                    break;
                case "2":
                    produkt_edytuj(produkty);
                    break;
                case "3":
                    produkt_usun(produkty);
                    break;
                case "4":
                    produkt_wyswietl(produkty);
                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("źle");
                    break;
            }
            break;
        case "3":
            Console.WriteLine("<PRODUKT Z MAGAZYNU");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Usun");
            Console.WriteLine("3. Wyjscie");
            string wybor3 = Console.ReadLine();
            switch (wybor3)
            {
                case "1":
                    produkt_magazyn_dodaj(produkty, magazyny);
                    break;
                case "2":
                    produkt_magazyn_usun(produkty, magazyny);
                    break;
                case "3":
                    Console.WriteLine("Porgram zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("źle");
                    break;
            }
            break;
        case "4":
            Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
            break;
        default:
            Console.WriteLine("źle");
            break;

    }
}
//PRODUKTY
//dodawanie produktow
static void produkt_dodaj(List<Produkt> produkty)
{
    try
    {
        Console.WriteLine("*DODAWANIE PRODUKTU*");
        Console.WriteLine("Podaj nazwe producenta:");
        string nazwaProducenta = Console.ReadLine();
        Console.WriteLine("Podaj nazwe produktu:");
        string nazwaProduktu = Console.ReadLine();
        Console.WriteLine("Podaj kategorie:");
        string kategoria = Console.ReadLine();
        Console.WriteLine("Podaj kod produktu:");
        string kodProduktu = Console.ReadLine();
        Console.WriteLine("Podaj cene:");
        int cena = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj opis:");
        string opis = Console.ReadLine();
        produkty.Add(new Produkt(nazwaProducenta, nazwaProduktu, kategoria, kodProduktu, cena, opis));
        Console.WriteLine("Produkt zostal dodny pomyslnie");
    }
    catch
    {
        Console.WriteLine("Nieprawidlowe cena. Produkt nie zostal dodany");
    }
}
//edycja produktow
static void produkt_edytuj(List<Produkt> produkty)
{
    try
    {
        Console.WriteLine("EDYCJA PRODUKTU");
        Console.WriteLine("Wybierz produkt do do edycji");
        int i = 0;
        foreach (Produkt produkt1 in produkty)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + produkty[i].nazwaProduktu);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj nazwe producenta:");
        string nazwaProducenta = Console.ReadLine();
        Console.WriteLine("Podaj nazwe produktu:");
        string nazwaProduktu = Console.ReadLine();
        Console.WriteLine("Podaj kategorie:");
        string kategoria = Console.ReadLine();
        Console.WriteLine("Podaj kod produktu:");
        string kodProduktu = Console.ReadLine();
        Console.WriteLine("Podaj cene:");
        int cena = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj opis:");
        string opis = Console.ReadLine();
        Produkt produkt = new Produkt(nazwaProducenta, nazwaProduktu, kategoria, kodProduktu, cena, opis);
        produkty[y - 1] = produkt;
        Console.WriteLine("Produkt zostal z edytowany pomyslnie");
    }
    catch
    {
        Console.WriteLine("Nieprawidlowa cena. Produkt nie zostal z edytowany");
    }
}
//usuwanie produktow
static void produkt_usun(List<Produkt> produkty)
{
    try
    {
        Console.WriteLine("USUWANIE PRODUKTU");
        Console.WriteLine("Wybierz produkt do usuniecia");
        int i = 0;
        foreach (Produkt produkt in produkty)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + produkty[i].nazwaProduktu);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine());
        produkty.RemoveAt(y - 1);
        Console.WriteLine("Produkt zostal pomyslnie usuniety");
    }
    catch
    {
        Console.WriteLine("Nieprawidlowy numer. Produkt nie zostal usuniety");
    }
}
//wyswietlanie produktow
static void produkt_wyswietl(List<Produkt> produkty)
{
    try
    {
        Console.WriteLine("WYSWIETLANIE PRODUKTOW");
        int i = 0;
        foreach (Produkt produkt in produkty)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + produkty[i].nazwaProducenta + ", " + produkty[i].nazwaProduktu + ", " + produkty[i].kategoria + ", " + produkty[i].kodProduktu + ", " + produkty[i].cena + ", " + produkty[i].opis);
            i++;
        }
    }
    catch
    {
        Console.WriteLine("Cos poszlo nie tak");
    }
}

//dodawanie magazynow
static void magazyn_dodaj(List<Magazyn> magazyny)
{
    try
    {
        Console.WriteLine("DODAWANIE MAGAZYNU");
        Console.WriteLine("Podaj ulice:");
        string ulica = Console.ReadLine();
        Console.WriteLine("Podaj kod pocztowy:");
        string kodPocztowy = Console.ReadLine();
        Console.WriteLine("Podaj miasto:");
        string miasto = Console.ReadLine();
        Console.WriteLine("Podaj numer posesji:");
        string numerPosesji = Console.ReadLine();
        Console.WriteLine("Podaj numer lokalu:");
        string numerLokalu = Console.ReadLine();
        Magazyn magazyn = new Magazyn(null, new Adres(ulica, kodPocztowy, miasto, numerPosesji, numerLokalu));
        magazyny.Add(magazyn);
        Console.WriteLine("Magazyn zostal dodany pomyslnie");
    }
    catch
    {
        Console.WriteLine("Cos poszlo nie tak");
    }
}
//edycja magazynow
static void magazyn_edytuj(List<Magazyn> magazyny)
{
    try
    {
        Console.WriteLine("EDYCJA MAGAZYNU");
        Console.WriteLine("Wybierz magazyn do edycji:");
        int i = 0;
        foreach (Magazyn magazyn1 in magazyny)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + magazyny[i].adresMagazynu.ulica);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine());
        magazyny[y - 1] = null;
        Console.WriteLine("Podaj ulice:");
        string ulica = Console.ReadLine();
        Console.WriteLine("Podaj kod pocztowy:");
        string kodPocztowy = Console.ReadLine();
        Console.WriteLine("Podaj miasto:");
        string miasto = Console.ReadLine();
        Console.WriteLine("Podaj numer posesji:");
        string numerPosesji = Console.ReadLine();
        Console.WriteLine("Podaj numer lokalu:");
        string numerLokalu = Console.ReadLine();
        Magazyn magazyn = new Magazyn(null, new Adres(ulica, kodPocztowy, miasto, numerPosesji, numerLokalu));
        magazyny[y - 1] = magazyn;
        Console.WriteLine("Magazyn zostal z edytowany pomyslnie");
    }
    catch
    {
        Console.WriteLine("Podany magazyn nie istnieje");
    }
}
//usuwanie magazynow
static void magazyn_usun(List<Magazyn> magazyny)
{
    try
    {
        Console.WriteLine("USUWANIE MAGAZYNU");
        Console.WriteLine("Wybierz magazyn do usuniecia:");
        int i = 0;
        foreach (Magazyn magazyn in magazyny)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + magazyny[i].adresMagazynu.ulica);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine());
        magazyny.RemoveAt(y - 1);
        Console.WriteLine("Magazyn zostal usuniety pomyslnie");
    }
    catch
    {
        Console.WriteLine("Podany magazyn nie istnieje");
    }
}
//wyswietlanie magazynow
static void magazyn_wyswietl(List<Magazyn> magazyny)
{
    try
    {
        Console.WriteLine("WYSWIETLANIE MAGAZYNOW");
        int i = 0;
        foreach (Magazyn magazyn in magazyny)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + magazyny[i].adresMagazynu.ulica + ", " + magazyny[i].adresMagazynu.kodPocztowy + ", " + magazyny[i].adresMagazynu.miejscowosc + ", " + magazyny[i].adresMagazynu.numerPosesji + ", " + magazyny[i].adresMagazynu.numerLokalu);
            i++;
        }
    }
    catch
    {
        Console.WriteLine("Cos poszlo nie tak");
    }
}



//dodawanie produku do magazynu
static void produkt_magazyn_dodaj(List<Produkt> produkty, List<Magazyn> magazyny)
{
    
    try { 
    
        Console.WriteLine("DODAWANIE PRODUKTU DO MAGAZYNU");
        Console.WriteLine("Wybierz produkt do dodania:");
        int i = 0;
        foreach (Produkt produkt in produkty)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + produkty[i].nazwaProduktu);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine("Wybierz magazyn do ktorego dodac produkt:");
        i = 0;
        foreach (Magazyn magazyn1 in magazyny)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + magazyny[i].adresMagazynu.ulica);
            i++;
        }
        int z = Convert.ToInt32(Console.ReadLine()) - 1;
        magazyny[z].produkty.Add(produkty[y]);
        Console.WriteLine("Produkt zostal pomyslnie dodany do wybranego magazynu");
    }
    catch
    {
        Console.WriteLine("cos poszlo nie tak");
    }
}
//usuwanie produktu z magazynu
static void produkt_magazyn_usun(List<Produkt> produkty, List<Magazyn> magazyny)
{
    try
    {
        Console.WriteLine("USUWANIE PRODUKTU Z MAGAZYNU");
        Console.WriteLine("Wybierz produkt do usuniecia:");
        int i = 0;
        foreach (Produkt produkt in produkty)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + produkty[i].nazwaProduktu);
            i++;
        }
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wybierz magazyn z ktorego usunac produkt:");
        i = 0;
        foreach (Magazyn magazyn in magazyny)
        {
            int x = i + 1;
            Console.WriteLine(x + ". " + magazyny[i].adresMagazynu.ulica);
            i++;
        }
        int z = Convert.ToInt32(Console.ReadLine());
        magazyny[z - 1].produkty.Remove(produkty[y - 1]);
        Console.WriteLine("Produkt zostal pomyslnie usuniety z wybranego magazynu");
    }
    catch
    {
        Console.WriteLine("cos poszlo nie tak");
    }
}
