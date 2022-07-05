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

    public string errorMessage;

    public Address(string name, string surname, string street, string city, string province, string zip, string errorMessage)
    {
        this.Name = name;
        this.Surname = surname;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Zip = zip;
        this.errorMessage = errorMessage;
    }

    public void PrintAddress()
    {
        Console.WriteLine("------ Address ------");


        if (this.errorMessage != "")
        {
            Console.WriteLine(this.errorMessage);
        } else
        {
            Console.WriteLine("\tName: {0}", this.Name);
            Console.WriteLine("\tSurname: {0}", this.Surname);
            Console.WriteLine("\tStreet: {0}", this.Street);
            Console.WriteLine("\tCity: {0}", this.City);
            Console.WriteLine("\tProvince: {0}", this.Province);
            Console.WriteLine("\tZip: {0}", this.Zip);
        }



        //Console.WriteLine("Surname:\t " + this.Surname + "\t");
        //Console.WriteLine("Street:\t " + this.Street + "\t");
        //Console.WriteLine("City:\t " + this.City + "\t");
        //Console.WriteLine("Province:\t " + this.Province + "\t");
        //Console.WriteLine("Zip:\t " + this.Zip + "\t");
        Console.WriteLine("---------------------");
    }
}