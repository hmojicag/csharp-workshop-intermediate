using System;

namespace one {
    public class Auto {
        private string model;
        public string Color;
        public string Year { get; set; }
        protected string bla;

        public Auto() {
            
        }

        public Auto(string model, string color, string year) {
            this.model = model;
            this.Color = color;
            this.Year = year;
        }
        
        public string Model {
            get { return model;  }
            set { model = value; }
        }

        public virtual void Arrancar() {
            Console.WriteLine("Run run");
        }

        private class MiniAuto {
            
        }
        
    }
}