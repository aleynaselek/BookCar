﻿using BookCar.Dto.AboutDtos;
using BookCar.Dto.BannerDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookCar.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public  IViewComponentResult Invoke() 
        { 
            return View();
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("https://localhost:7094/api/Banners");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
    }
}
