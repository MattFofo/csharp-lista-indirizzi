//In questo esercizio dovrete leggere un file CSV (che vi allego), non tanto differente da quanto visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

internal class Address
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Province { get; private set; }
    public string Zip { get; private set; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        this.Name = name;
        this.Surname = surname;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Zip = zip;
    }

    public void PrintAddress()
    {
        Console.WriteLine("------ Address ------");
        Console.WriteLine("Name: " + this.Name);
        Console.WriteLine("Surname: " + this.Surname);
        Console.WriteLine("Street: " + this.Street);
        Console.WriteLine("City: " + this.City);
        Console.WriteLine("Province: " + this.Province);
        Console.WriteLine("Zip: " + this.Zip);
        Console.WriteLine("---------------------");
    }
}