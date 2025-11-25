namespace Portfolio.Models
{
    public class Projeto
    {
        private const string ImageBaseUrl = "https://raw.githubusercontent.com/fernandonline/portfolio-data/main/";
        public int Id { get; set; }
        public string? Img { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<string>? Tech { get; set; }
        public string? GithubCode { get; set; }
        public string? Deploy { get; set; }
        public string? ImgUrl => string.IsNullOrWhiteSpace(Img) ? null : ImageBaseUrl + Img;
    }
}
