using System;

namespace MySchoolAgenda {
    public class ImportantHomeworkNote : HomeworkNote {
        public override string HTMLRenderer() {
            return "<h1>This is a Important Homework Note</h1>";
        }
    }
}