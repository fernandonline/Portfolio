namespace Portfolio.Components
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tech { get; set; }
        public string GithubCode { get; set; }
        public string Deploy { get; set; }
    }

}
