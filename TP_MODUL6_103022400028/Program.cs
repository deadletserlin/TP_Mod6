using System;
namespace TP_MODUL6_103022400028
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaMusicTrack lagu = new SayaMusicTrack("Blue");

                for (int i = 0; i < 5; i++)
                {
                    lagu.IncreasePlayCount(5000000);
                }
                lagu.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}git add .
git commit -m "menambahkan implementasi design by contract"
git push -u origin main