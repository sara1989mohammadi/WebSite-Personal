
namespace Contracts
{
  public  class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public string Publisher { get; set; }
        public string DatePublisher { get; set; }
        public string ImageUrl { get; set; }
    }
}
