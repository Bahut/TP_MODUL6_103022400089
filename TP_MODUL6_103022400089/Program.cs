
using TP_MOD6_103022400089;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Lagu Galau");

        lagu1.IncreasePlayCount(10);
        lagu1.PrintTrackDetails();
    }
}