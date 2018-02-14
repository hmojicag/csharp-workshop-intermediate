using System;

namespace MySchoolAgenda {
    public abstract class Note : IRenderizable {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime FinalDate { get; set; }

        public virtual string HTMLRenderer() {
            return "<h1>This is a Note</h1>";
        }

    }
}