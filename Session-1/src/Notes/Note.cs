using System;

namespace csharp_workshop_intermediate.Notes {
    public abstract class Note {
        protected string Description { get; set; }
        protected DateTime FinalDate { get; set; }
        protected DateTime CreatedDate { get; set; }
    }
}