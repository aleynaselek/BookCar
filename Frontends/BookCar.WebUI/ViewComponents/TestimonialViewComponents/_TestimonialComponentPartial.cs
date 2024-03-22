using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BookCar.Dto.AboutDtos;
using BookCar.Dto.TestimonialDtos;

namespace BookCar.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =  _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7094/api/Testimonials");
            if (responseMessage.IsSuccessStatusCode) 
            { 
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
//https://localhost:7094/api/Abouts
//DeserializeObject: api türünde gelen veriyi text türünde göstermek istersek
//SerializeObject: api türünde text türündegelen veriyi text türünde göstermek istersek (ekleme, güncelleme vb.)

