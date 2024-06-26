namespace SK_API{
    public class CoursePlanRequestModel{
        public string Language { get; set; }
        public string MacroSubject { get; set; }
        public string Title { get; set; }
        public TextLevel Level { get; set; }
        public string Topic { get; set; }
        public int NumberOfLessons { get; set; }
        public int LessonDuration { get; set; }
        public double Temperature { get; set; }
    
        public CoursePlanRequestModel(string language, string macroSubject, string title, TextLevel level, string topic, int nol, int duration, double temperature){
            Language = language;
            MacroSubject = macroSubject;
            Title = title;
            Level = level;
            Topic = topic;
            NumberOfLessons = nol;
            LessonDuration = duration;
            Temperature = temperature;
        }

        public CoursePlanRequestModel(){}
    }
}