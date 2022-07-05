//In questo esercizio dovrete leggere un file CSV (che vi allego), non tanto differente da quanto visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

StreamReader addressesFromFile = File.OpenText("D:\\VisualStudio2022\\Experis\\csharp-lista-indirizzi\\addresses.csv");
addressesFromFile.ReadLine();


List<Address> addresses = new List<Address>();  

//ciclo le linee del file
while (!addressesFromFile.EndOfStream)
{
    string line = addressesFromFile.ReadLine();
    string[] data = line.Split(",");
    string formatError = "";

    if (data.Length != 6)
    {
        formatError = "Il formato dell'indirizzo è errato";

    }
    
    string name;
    string surname;
    string street;
    string city;
    string province;
    string zip;


    try
    {
        name = data[0];
    }
    catch (Exception exc)
    {

        name = "";
    }

    try
    {
        surname = data[1];
    }
    catch (Exception exp)
    {
        surname = "";
    }

    try
    {
        street = data[2];
    }
    catch (Exception exc)
    {

        street = "";
    }

    try
    {
        city = data[3];
    }
    catch (Exception exp)
    {
        city = "";
    }



    try
    {
        province = data[4];
    }
    catch (Exception exc)
    {

        province = "";
    }


    try
    {
        zip = data[5];
    }
    catch (Exception exp)
    {
        zip = "";
    }



    

    Address address = new Address(name, surname, street, city, province, zip, formatError);
    addresses.Add(address);
}

addressesFromFile.Close();

//stampo gli indirizzi
foreach (var address in addresses)
{
    address.PrintAddress();
}