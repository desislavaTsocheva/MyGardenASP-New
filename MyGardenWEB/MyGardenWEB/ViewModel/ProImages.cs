using MyGardenWEB.Data;

namespace MyGardenWEB.ViewModel
{
    public class ProImages
    {
        public List<IFormFile> Images { get; set; } 
        public int ProductId {  get; set; } 
        public Product Products { get; set; }    
    }
}
