namespace Spotiflix.Data
{
    public enum EntertaintmentType { Movie, Series, Music};
    public abstract class EntertainmentItem
    {
        public virtual EntertaintmentType type { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int length { get; set; }
        public DateTime release_date { get; set; } = DateTime.Now;
        public string streaming_service { get; set; }
        public virtual string getLength()
        {
            return length.ToString();
        }
    }
}
