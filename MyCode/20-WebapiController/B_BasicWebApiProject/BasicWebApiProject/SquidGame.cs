namespace BasicWebApiProject
{
    public class SquidGame
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public Rating Rating { get; set; }
        public int Year { get; set; }
        public IList<string> Starts { get; set; }
        public string Language { get; set; }
        public string Budget { get; set; }
    }

    public class Rating
    {
        public float Imdb { get; set; }
        public float RottenTomatoes { get; set; }
    }
}
