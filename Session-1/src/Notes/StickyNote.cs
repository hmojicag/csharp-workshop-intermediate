namespace csharp_workshop_intermediate.Notes {
    public class StickyNote : Note, IRenderizable {
        private Color Color { get; set; }
        
        public string HTMLRedender() {
            return "This is an StickyNote";
        }
    }
}