using AutoSDK.Extensions;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Readers.Exceptions;

namespace AutoSDK.UnitTests;

[TestClass]
public class ProcessingTests : VerifyBase
{
    [DataTestMethod]
    [DataRow("openai.yaml")]
    public async Task ComputeDiscriminators(string resourceName)
    {
        var yamlOrJson = new H.Resource(resourceName).AsString();
        
        OpenApiDiagnostic originalDiagnostics;
        try
        {
            _ = new OpenApiStringReader().Read(yamlOrJson, out originalDiagnostics);
        }
        catch (OpenApiUnsupportedSpecVersionException e)
        {
            originalDiagnostics = new OpenApiDiagnostic
            {
                Errors =
                {
                    new OpenApiError(pointer: string.Empty, e.Message),
                }
            };
        }

        if (OpenApi31Support.IsOpenApi31(yamlOrJson))
        {
            yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
        }
        
        var document = new OpenApiStringReader().Read(yamlOrJson, out var newDiagnostics);
        document = document.ComputeDiscriminators();
        
        yamlOrJson = document.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
        
        await Task.WhenAll(
            Verify(originalDiagnostics.Errors)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("OriginalErrors"),
            Verify(originalDiagnostics.Warnings)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("OriginalWarnings"),
            Verify(newDiagnostics.Errors)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("NewErrors"),
            Verify(newDiagnostics.Warnings)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("NewWarnings"),
            Verify(yamlOrJson)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .UseFileName("_")
                .AutoVerify()
        );
    }
}