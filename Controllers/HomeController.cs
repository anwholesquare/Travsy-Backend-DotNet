using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Travsy_Backend_DotNet.Models;

namespace Travsy_Backend_DotNet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public String Index()
    {
        return "{\"name\": \"Travsy AI!\"}";
    }


    public String Public()
    {
        return "{\"name\": \"Travsy AI!\"}";
    }

    public String Privacy()
    {
        string privacyText = @"{
      ""PrivacyPolicy"": {
        ""LastUpdated"": ""2024-05-28"",
        ""Introduction"": {
          ""Content"": ""Welcome to TravsyAI! Your privacy is important to us. This Privacy Policy explains how we collect, use, disclose, and safeguard your information when you use our services. By using TravsyAI, you agree to the terms of this Privacy Policy.""
        },
        ""InformationWeCollect"": {
          ""PersonalInformation"": ""Name, email address, phone number, payment information, and other personal details."",
          ""TravelPreferences"": ""Destinations, interests, travel dates, and other preferences."",
          ""UsageData"": ""Information about how you use our website and services, including your IP address, browser type, and operating system."",
          ""LocationData"": ""Information about your location when you use our services.""
        },
        ""HowWeUseYourInformation"": {
          ""Content"": [
        ""To provide and maintain our services."",
        ""To process your transactions and bookings."",
        ""To personalize your travel planning experience."",
        ""To communicate with you, including sending you updates and promotional materials."",
        ""To improve our website and services."",
        ""To comply with legal obligations.""
          ]
        },
        ""HowWeShareYourInformation"": {
          ""ServiceProviders"": ""We may share your information with third-party vendors who perform services on our behalf, such as payment processing, data analysis, and customer support."",
          ""BusinessTransfers"": ""If we are involved in a merger, acquisition, or asset sale, your information may be transferred as part of that transaction."",
          ""LegalRequirements"": ""We may disclose your information if required by law or in response to valid requests by public authorities."",
          ""Consent"": ""We may share your information with your consent or at your direction.""
        },
        ""DataSecurity"": {
          ""Content"": ""We implement appropriate technical and organizational measures to protect your personal data from unauthorized access, use, or disclosure. However, no internet or email transmission is ever fully secure or error-free.""
        }
      }
    }";

        return privacyText;
    }
}
