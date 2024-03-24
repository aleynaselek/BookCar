using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; 
using BookCar.Dto.BlogDtos;

namespace BookCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogsWithAuthorsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetLast3BlogsWithAuthorsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =  _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7094/api/Blogs/GetLast3BlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode) 
            { 
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthors>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
//https://localhost:7094/api/Abouts
//DeserializeObject: api türünde gelen veriyi text türünde göstermek istersek
//SerializeObject: api türünde text türündegelen veriyi text türünde göstermek istersek (ekleme, güncelleme vb.)

