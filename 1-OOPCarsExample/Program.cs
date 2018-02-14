using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Model = "BMW X1";
            auto.Color = "Blanco";
            auto.Year = "1997";
            
            Auto auto1 = new Auto("Civic","Negro","2016");
            
            AutoSport autoSport = new AutoSport();
            autoSport.Model = "Ferrari";
            autoSport.Color = "Rojo";
            autoSport.Year = "2018";
            
            AutoClassic autoClassic = new AutoClassic();
            autoClassic.Model = "OldsMobile";
            autoClassic.Color = "Arena";
            autoClassic.Year = "1789";

            Auto[] autos = new Auto[3];
            autos[0] = auto;
            autos[1] = autoSport;
            autos[2] = autoClassic;

            foreach (Auto a in autos) {
                a.Arrancar();
            }

            Moto moto = new Moto();
            moto.Arrancar();
            moto.Arrancar("ULL");
            moto.Arrancar("ULL","OOLLL");
        }
    }
}
