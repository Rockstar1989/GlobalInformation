using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GlobalInformation.Models;
using GlobalInformation.Services.Country;

namespace GlobalInformation.Controllers;

public class HomeController : Controller
{
    private readonly ICountryService _countryService;

    public HomeController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    public async Task<IActionResult> Index()
    {
        var response = await _countryService.GetAllCountriesAsync();
        return View(response);
    }

    [HttpGet]
    public async Task<IActionResult> CountryDetails(string countryName)
    {
        var response = await _countryService.GetCountryDetailsAsync(countryName);
        return PartialView("_CountryDetails", response);
    }

    [HttpGet]
    public async Task<IActionResult> RegionDetails(string regionName)
    {
        var response = await _countryService.GetRegionDetailsAsync(regionName);
        return PartialView("_RegionDetails", response);
    }

    [HttpGet]
    public async Task<IActionResult> SubregionDetails(string subregionName)
    {
        var response = await _countryService.GetSubRegionDetailsAsync(subregionName);
        return PartialView("_SubregionDetails", response);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}