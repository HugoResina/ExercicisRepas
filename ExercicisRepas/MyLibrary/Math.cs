namespace MyLibrary
{
    public class Math
    {
        public static string SecondsToTime(int secondsInput)
        {
            
            int hours;
            int minutes;
            int seconds;
            int rest;

            hours = secondsInput / 3600;
            rest = secondsInput % 3600;
            minutes = rest / 60;
            rest = rest % 60;
            seconds = rest;

            string Time = string.Format("Hores: {0}, Minuts: {1}, Segons: {2}", hours, minutes, seconds);
            return Time;



        }
    }
}
