using System;

namespace MySchoolAgenda {
    public class StickyNote : Note {
        public Color Color { get; set; }

        public override string HTMLRenderer() {
            return "<h1>This is a Sticky Note</h1>";
        }

    }
}