namespace Spotiflix.Data
{
    public class Movie : EntertainmentItem
    {
        public override EntertaintmentType type { get; set; } = EntertaintmentType.Movie;
        public override string getLength()
        {
            int hours = (length / 60);
            double minutes = Math.Round(((length / 60f) - hours) * 60);
            return $"{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}";
        }
    }
}
