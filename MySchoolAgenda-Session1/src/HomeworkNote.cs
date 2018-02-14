using System;

namespace MySchoolAgenda {
    public class HomeworkNote : Note {
        public string Subject { get; set; }

        public override string HTMLRenderer() {
            return "<h1>This is a Homework Note</h1>";
        }

    }
}