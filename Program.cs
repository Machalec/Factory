public abstract class Zvire
{
    // Druh zvířete
    public string Druh { get; set; }

    // Věk zvířete
    public int Vek { get; set; }

    // Konstruktor přijímající druh a věk
    public Zvire(string druh, int vek)
    {
        Druh = druh;
        Vek = vek;
    }

    // Abstraktní metoda pro zvuk, kterou každé zvíře implementuje
    public abstract void VydatZvuk();
}


public class Pes : Zvire
{
    public Pes(int vek) : base("Pes domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Haf!");
}

public class Kocka : Zvire
{
    public Kocka(int vek) : base("Kočka domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Mňau!");
}

public class Kralik : Zvire
{
    public Kralik(int vek) : base("Králík domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Písk!");
}

public class Kure : Zvire
{
    public Kure(int vek) : base("Kuře domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Píp!");
}

public class Kohout : Zvire
{
    public Kohout(int vek) : base("Kohout domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Kikirikí!");
}

public class Kachna : Zvire
{
    public Kachna(int vek) : base("Kachna domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Kvak!");
}

public class Ovce : Zvire
{
    public Ovce(int vek) : base("Ovce domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Béé!");
}

public class Kozel : Zvire
{
    public Kozel(int vek) : base("Koza domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Méé!");
}

public class Krava : Zvire
{
    public Krava(int vek) : base("Tur domácí", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Múú!");
}

public class Kun : Zvire
{
    public Kun(int vek) : base("Friský kůň", vek) { }
    public override void VydatZvuk() => Console.WriteLine("Řehé!");
}

public class VytvorZvire
{
    public static Pes VyPsa(int vek) => new Pes(vek);
    public static Kocka VyKocku(int vek) => new Kocka(vek);
    public static Kralik VyKralika(int vek) => new Kralik(vek);
    public static Kure VyKure(int vek) => new Kure(vek);
    public static Kohout VyKohouta(int vek) => new Kohout(vek);
    public static Kachna VyKachnu(int vek) => new Kachna(vek);
    public static Ovce VyOvci(int vek) => new Ovce(vek);
    public static Kozel VyKozla(int vek) => new Kozel(vek);
    public static Krava VyKravu(int vek) => new Krava(vek);
    public static Kun VyKone(int vek) => new Kun(vek);
}

public class Program
{
    public static void Main(string[] args)
    {
        // Testování všech 10 zvířat s podrobnějšími druhy
        var pes = VytvorZvire.VyPsa(5);
        Console.WriteLine($"{pes.Druh} ve věku {pes.Vek} let vydává zvuk:");
        pes.VydatZvuk();

        var kocka = VytvorZvire.VyKocku(3);
        Console.WriteLine($"{kocka.Druh} ve věku {kocka.Vek} let vydává zvuk:");
        kocka.VydatZvuk();

        var kralik = VytvorZvire.VyKralika(3);
        Console.WriteLine($"{kralik.Druh} ve věku {kralik.Vek} let vydává zvuk:");
        kralik.VydatZvuk();

        var kure = VytvorZvire.VyKure(2);
        Console.WriteLine($"{kure.Druh} ve věku {kure.Vek} let vydává zvuk:");
        kure.VydatZvuk();

        var kohout = VytvorZvire.VyKohouta(3);
        Console.WriteLine($"{kohout.Druh} ve věku {kohout.Vek} let vydává zvuk:");
        kohout.VydatZvuk();

        var kachna = VytvorZvire.VyKachnu(4);
        Console.WriteLine($"{kachna.Druh} ve věku {kachna.Vek} let vydává zvuk:");
        kachna.VydatZvuk();

        var ovce = VytvorZvire.VyOvci(5);
        Console.WriteLine($"{ovce.Druh} ve věku {ovce.Vek} let vydává zvuk:");
        ovce.VydatZvuk();

        var kozel = VytvorZvire.VyKozla(6);
        Console.WriteLine($"{kozel.Druh} ve věku {kozel.Vek} let vydává zvuk:");
        kozel.VydatZvuk();

        var krava = VytvorZvire.VyKravu(7);
        Console.WriteLine($"{krava.Druh} ve věku {krava.Vek} let vydává zvuk:");
        krava.VydatZvuk();

        var kun = VytvorZvire.VyKone(4);
        Console.WriteLine($"{kun.Druh} ve věku {kun.Vek} let vydává zvuk:");
        kun.VydatZvuk();
    }
}
