namespace Task_2
{
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }// Правда или нет

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
           Text = text;
           TrueFalse = trueFalse;
        }
    }

}
