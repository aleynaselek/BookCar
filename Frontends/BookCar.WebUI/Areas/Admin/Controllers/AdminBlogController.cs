using BookCar.Dto.BlogDtos; 
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookCar.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminBlog")]
    public class AdminBlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminBlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

     
        
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7094/api/Blogs/GetAllBlogsWithAuthorList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadAsStringAsync();
                var Blogs = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(result);
                return View(Blogs);
            }
            return View();
        }
        [HttpGet]
        [Route("CreateBlog")]
        public async Task<IActionResult> CreateBlog()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateBlog")]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBlogDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7094/api/Blogs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminBlog", new {area="Admin"});
            }
            return View();
        }


        [HttpGet]
        [Route("UpdateBlog/{id}")]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7094/api/GetBlogByAuthorId?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBlogDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("UpdateBlog/{id}")]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBlogDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7094/api/Blogs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminBlog", new { area = "Admin" });
            }
            return View();
        }

        [Route("RemoveBlog/{id}")]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7094/api/Blogs?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminBlog", new { area = "Admin" });
            }
            return View();
        }
    }
}
