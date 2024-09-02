namespace Backend_Jørgen;

class Program
{
    static void Main(string[] args)
    {
        string helloWorld = "Hello World";
        int myNumber = 10;
        // string datatype variable
        Console.WriteLine(myNumber +10);
        // desimaltall/double variable
        double myDecimal = 10.25;
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
       
        // Skriver ut en melding til brukeren
        Console.WriteLine("Hei, hva heter du?");
        // String variabel navn holder på verdien vi gir til konsollen
        string? navn= Console.ReadLine();
        // Skriver ut en liten melding + navnet som er gitt til konsollen
        Console.WriteLine("Hei " + navn);
        // char typen tar en bestemt bokstav
        char a = 'a';
        Console.WriteLine(a);

    }
}
