Console.WriteLine("Name thy dog:");

string ladoganame = Console.ReadLine();


mikskoer mina = new mikskoer(ladoganame); //kujuta ette 6 käppa, ma kardaksin
//mina._name = "Henri?";

mikskoer teie = new mikskoer("?");
//teie._name = "?";


mina.HeBARKED();
Console.WriteLine($"My dogs name is {mina.Name}");
Console.WriteLine($"The power level: {mina.thepowerlevelistoomuch}");


while (mina.thepowerlevelistoomuch != 5)
{
    mina.HeBARKED();
}


mina.Rename("Baddest boy.");

mina.plahvatamine();

class mikskoer
{
    private string _name = "Koer?";
    private int _powerLevel_MAKUULSINKOERA = 0;


    public mikskoer(string namaewa)
    {
        _name = namaewa;
        _powerLevel_MAKUULSINKOERA = 0;
    }

    public string Name
    {
        get { return _name; }

    }

    public int thepowerlevelistoomuch
    {
        get { return _powerLevel_MAKUULSINKOERA; }

    }

    public void Rename(string newname)
    {
        _name = newname;
        Console.WriteLine($"Doggo's name has been changed to {newname}"); //oota, KOER MUUDAB ENDA NIME??
    }


    public void HeBARKED()
    {
        Console.WriteLine("Woof woof biatch!"); //näha seda 5 korda järjest on nii hea, kõik kood võiks sihuke olla
        _powerLevel_MAKUULSINKOERA++;
    }

    public void plahvatamine() //bruh, wiggle wiggle?
    {
        Console.WriteLine("He is close to exploding!");
    }

}

