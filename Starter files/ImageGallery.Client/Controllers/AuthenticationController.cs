using System.Text;
using System.Text.Json;
using ImageGallery.Client.ViewModels;
using ImageGallery.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ImageGallery.Client.Controllers;


public class AuthenticationController : Controller
{
    //private readonly IHttpClientFactory _httpClientFactory;
    //private readonly ILogger<GalleryController> _logger;

    //public GalleryController(IHttpClientFactory httpClientFactory,
    //    ILogger<GalleryController> logger)
    //{
    //    _httpClientFactory = httpClientFactory ??
    //                         throw new ArgumentNullException(nameof(httpClientFactory));
    //    _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    //}
    [Authorize]
    public async Task Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
    }

    public IActionResult AccessDenied()
    {
        return View();
    }
    
}