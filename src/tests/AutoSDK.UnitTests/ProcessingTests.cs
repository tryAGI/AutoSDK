using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class ProcessingTests : VerifyBase
{
    [TestMethod]
    [DataRow("openai.yaml")]
    [DataRow("cohere.yaml")]
    public async Task ComputeDiscriminators(string resourceName)
    {
        var yamlOrJson = new H.Resource(resourceName).AsString();
        
        var (document, diagnostics) = OpenApiDocument.Parse(yamlOrJson);
        if (document == null)
        {
            throw new InvalidOperationException("Document is null");
        }
        
        document = document.ComputeDiscriminators();
        
        yamlOrJson = await document.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);
        
        await Task.WhenAll(
            Verify(diagnostics?.Errors ?? [])
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("Errors"),
            Verify(diagnostics?.Warnings ?? [])
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("Warnings"),
            Verify(yamlOrJson)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .UseFileName("_")
                .AutoVerify()
        );
    }
}