using System;
using TP_MOD6_103022400002;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Lagu Santai");

        lagu1.IncreasePlayCount(10);
        lagu1.PrintTrackDetails();

        Console.ReadLine(); 
    }
}