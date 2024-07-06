using OpenApiGenerator.Core.Helpers;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public void SmartNamedAnyOfNames_Valid()
    {
        SmartNamedAnyOfNames.ComputeSmartName(
            typeName: "ChatCompletionRequestMessageContentPartText",
            className: "ChatCompletionRequestMessageContentPart").Should().Be("Text");
    }
    
    [TestMethod]
    public void DateTimeParameterSerialization_Valid()
    {
        $"{new DateTime(year: 2022, 1, 1):yyyy-MM-dd}".Should().Be("2022-01-01");
        $"{new DateTime(year: 2022, 1, 1):yyyy-MM-ddTHH:mm:ssZ}".Should().Be("2022-01-01T00:00:00Z");
    }
    
    [TestMethod]
    public void UrlWithPort_Concat()
    {
        var baseUri = new Uri("https://localhost:7293");
        
        new Uri(baseUri.AbsoluteUri.TrimEnd('/') + "/api/Stats", UriKind.RelativeOrAbsolute)
            .Should().Be(new Uri("https://localhost:7293/api/Stats"));
    }
    
    [TestMethod]
    public void UrlWithVersion_Concat()
    {
        var baseUri = new Uri("https://api.openai.com/v1");
        
        new Uri(baseUri.AbsoluteUri.TrimEnd('/') + "/chat/completions", UriKind.RelativeOrAbsolute)
            .Should().Be(new Uri("https://api.openai.com/v1/chat/completions"));
    }
    //
    // [TestMethod]
    // public void MultipartFormDataContent()
    // {
    //     using var __multiPartContent = new global::System.Net.Http.MultipartFormDataContent();
    //     __multiPartContent.Add(content: new global::System.Net.Http.StringContent("value1"), name: "key1");
    //     
    //     // Add file content
    //     var fileContent = new global::System.Net.Http.ByteArrayContent(System.IO.File.ReadAllBytes("path/to/file"));
    //     fileContent.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data");
    //     __multiPartContent.Add(content: fileContent, name: "file", fileName: "filename.ext");
    // }
}