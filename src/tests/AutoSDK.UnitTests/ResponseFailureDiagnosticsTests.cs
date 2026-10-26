using System.Net;
using System.Reflection;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class ResponseFailureDiagnosticsTests
{
    [TestMethod]
    [DataRow(false, JsonSerializerType.SystemTextJson)]
    [DataRow(true, JsonSerializerType.SystemTextJson)]
    [DataRow(false, JsonSerializerType.NewtonsoftJson)]
    [DataRow(true, JsonSerializerType.NewtonsoftJson)]
    public void SuccessFailure_KeepsCauseBeforeBoundedPreviewAndPreservesBody(bool hierarchy, JsonSerializerType serializer)
    {
        var source = Sources.GenerateExceptions(Settings.Default with
        {
            Namespace = "Fixture", GenerateHttpExceptionHierarchy = hierarchy, JsonSerializerType = serializer,
        });
        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!).Split(Path.PathSeparator)
            .Select(path => MetadataReference.CreateFromFile(path));
        var compilation = CSharpCompilation.Create("FailureFixture" + Guid.NewGuid().ToString("N"),
            [CSharpSyntaxTree.ParseText(source)], references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        using var stream = new MemoryStream();
        var result = compilation.Emit(stream);
        result.Success.Should().BeTrue(string.Join(Environment.NewLine, result.Diagnostics));
        var type = Assembly.Load(stream.ToArray()).GetType("Fixture.ApiException")!;
        var create = type.GetMethods().Single(method => method.Name == "Create" && method.GetParameters().Length == 5);
        var body = "{\"image\":\"" + new string('A', 100_000) + "\"}";
        var cause = new NotSupportedException("Missing System.Byte[] JsonTypeInfo");
        var error = (Exception)create.Invoke(null, [HttpStatusCode.OK, body, cause, body, null])!;
        error.Message.Length.Should().BeLessThan(1600);
        error.ToString()[..Math.Min(1024, error.ToString().Length)].Should().Contain("NotSupportedException", "System.Byte[] JsonTypeInfo");
        type.GetProperty("ResponseBody")!.GetValue(error).Should().Be(body);
        type.GetProperty("StatusCode")!.GetValue(error).Should().Be(HttpStatusCode.OK);
        error.InnerException.Should().BeSameAs(cause);

        Exception jsonCause = serializer == JsonSerializerType.SystemTextJson
            ? new System.Text.Json.JsonException("Invalid field", "$.data[0].image", 7, 32)
            : new Newtonsoft.Json.JsonReaderException("Invalid field", "$.data[0].image", 7, 32, null);
        var jsonError = (Exception)create.Invoke(null, [HttpStatusCode.Created, body, jsonCause, body, null])!;
        jsonError.Message.Should().Contain("$.data[0].image");
        var serviceError = (Exception)create.Invoke(null, [HttpStatusCode.NotFound, "service rejection", cause, body, null])!;
        serviceError.Message.Should().Be("service rejection");
        serviceError.GetType().Name.Should().Be(hierarchy ? "NotFoundException" : "ApiException");
        serviceError.InnerException.Should().BeSameAs(cause);
    }
}
