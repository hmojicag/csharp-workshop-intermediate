namespace csharp_workshop_intermediate.Notes {
    public class EventNote : Note, IRenderizable {
        private string Place { get; set; }
        
        public string HTMLRedender() {
            return "This is an EventNote";
        }
    }
}