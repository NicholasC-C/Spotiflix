namespace Spotiflix.Data
{
    public class Music : EntertainmentItem
    {
        public override EntertaintmentType type { get; set; } = EntertaintmentType.Music;
        public string artist { get; set; }
        public string album { get; set; }
        public override string getLength()
        {
            return $"{length}s";
        }
    }
}
