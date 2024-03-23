using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; 
using BookCar.Dto.FooterAddressDtos; 

namespace BookCar.WebUI.ViewComponents.FooterAddressComponents
{
    public class _FooterAddressComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FooterAddressComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =  _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7094/api/FooterAddress");
            if (responseMessage.IsSuccessStatusCode) 
            { 
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
//https://localhost:7094/api/Abouts
//DeserializeObject: api türünde gelen veriyi text türünde göstermek istersek
//SerializeObject: api türünde text türündegelen veriyi text türünde göstermek istersek (ekleme, güncelleme vb.)

