using AutoSDK.Models;
using AutoSDK.Serialization.Form;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    private static MethodParameter CreateQueryParameter(TypeData type, bool isRequired = false, string name = "param") =>
        MethodParameter.Default with
        {
            Id = name,
            Name = name,
            Type = type,
            IsRequired = isRequired,
            Location = ParameterLocation.Query,
        };

    [TestMethod]
    public void ParameterSerializer_BoolOptional_UsesLowerInvariant()
    {
        // Arrange
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "bool?" },
            isRequired: false);

        // Act
        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        // Assert
        result.Should().ContainSingle()
            .Which.Value.Should().Contain("ToLowerInvariant");
    }

    [TestMethod]
    public void ParameterSerializer_BoolRequired_UsesLowerInvariant()
    {
        // Arrange
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "bool" },
            isRequired: true);

        // Act
        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        // Assert
        result.Should().ContainSingle()
            .Which.Value.Should().Contain("ToLowerInvariant");
    }

    [TestMethod]
    public void ParameterSerializer_Int_DoesNotUseLowerInvariant()
    {
        // Arrange
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "int?" },
            isRequired: false);

        // Act
        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        // Assert
        result.Should().ContainSingle()
            .Which.Value.Should().NotContain("ToLowerInvariant");
    }

    [TestMethod]
    public void ParameterSerializer_String_DoesNotUseLowerInvariant()
    {
        // Arrange
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "string" },
            isRequired: false);

        // Act
        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        // Assert
        result.Should().ContainSingle()
            .Which.Value.Should().NotContain("ToLowerInvariant");
    }
}
