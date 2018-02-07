using System;

namespace one {
    public class AutoClassic : Auto {
        public string ExcesoDeKM { get; set; }

        public override void Arrancar() {
            Console.WriteLine("rrrrrrRRRunn");
        }
    }
}