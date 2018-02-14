namespace csharp_workshop_intermediate.Notes {
    public class HomeworkNote : Note, IRenderizable {
        protected string Subject { get; set; }

        public virtual string HTMLRedender() {
            return "This is a HomeworkNote";
        }
    }
}