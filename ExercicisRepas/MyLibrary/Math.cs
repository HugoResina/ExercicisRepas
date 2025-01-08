namespace MyLibrary
{
    public class Math
    {
        public static void SecondsToTime(int secondsInput)
        {
            const string Time = "Hores: {0}, Minuts: {1}, Segons: {2}";
            int hours;
            int minutes;
            int seconds;
            int rest;

            hours = secondsInput / 3600;
            rest = secondsInput % 3600;
            minutes = rest / 60;
            rest = rest % 60;

            seconds = rest;
            Console.WriteLine(Time, hours, minutes, seconds);


        }
    }
}
