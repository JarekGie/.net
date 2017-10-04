namespace firstProject
{
    public abstract class StringOperations
    {
        public abstract string Substring(string candidate, int start, int length); //beatka, 1,3 => eat
       
        public abstract string GetName(); //zwróć imię i nazwisko

        public abstract string GlueBeginingEnd(string candidate); //bartlomiej => bjaeritmlo

        public abstract int CountOccurences(string candidate, char needle);//zlicza wystąpienia litery w wyrazie

        public abstract int LetterPositionInString(string candidate, char needle); //bartek, k=>5

        public abstract string LetterReplace(string candidate, char needle, char replace);//beatka, e, s  =>bsatka; beatka, a,b =>bebtkb

        public abstract string StringReplace(string candidate, string needle, string replace);// bartlomiej, art, beatka => bbeatkalomiej
    }
}