namespace Spotiflix.Data
{
    public class Series : EntertainmentItem
    {
        public override EntertaintmentType type { get; set; } = EntertaintmentType.Series;
        public int episodes { get; set; }
        public int seasons { get; set; }
        public override string getLength()
        {
            return $"{length}m";
        }
    }
}
