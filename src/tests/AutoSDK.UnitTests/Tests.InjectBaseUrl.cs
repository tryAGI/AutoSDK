using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void InjectBaseUrl_EmptyServers_InsertsServer()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Servers = new List<OpenApiServer>(),
        };
        var settings = Settings.Default with
        {
            BaseUrl = "https://api.example.com/v1",
        };

        // Act
        document.InjectBaseUrl(settings);

        // Assert
        document.Servers.Should().HaveCount(1);
        document.Servers[0].Url.Should().Be("https://api.example.com/v1");
    }

    [TestMethod]
    public void InjectBaseUrl_ExistingServers_InsertsAtPositionZero()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Servers = new List<OpenApiServer>
            {
                new() { Url = "https://existing.example.com" },
            },
        };
        var settings = Settings.Default with
        {
            BaseUrl = "https://api.example.com/v1",
        };

        // Act
        document.InjectBaseUrl(settings);

        // Assert
        document.Servers.Should().HaveCount(2);
        document.Servers[0].Url.Should().Be("https://api.example.com/v1");
        document.Servers[1].Url.Should().Be("https://existing.example.com");
    }

    [TestMethod]
    public void InjectBaseUrl_InvalidUrl_SkipsInjection()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Servers = new List<OpenApiServer>(),
        };
        var settings = Settings.Default with
        {
            BaseUrl = "not a valid url",
        };

        // Act
        document.InjectBaseUrl(settings);

        // Assert
        document.Servers.Should().BeEmpty();
    }
}
