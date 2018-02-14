using System;

namespace MySchoolAgenda {
    public class EventNote : Note {
        public string Place { get; set; }

        public override string HTMLRenderer() {
            return "<h1>This is an Event Note</h1>";
        }

    }
}