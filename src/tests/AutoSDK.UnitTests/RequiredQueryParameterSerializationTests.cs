using AutoSDK.Models;
using AutoSDK.Serialization.Form;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void ParameterSerializer_ObjectRequired_ChecksToStringResult()
    {
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "object" },
            isRequired: true);

        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        result.Should().ContainSingle()
            .Which.Value.Should().Be("param.ToString() ?? throw new global::System.InvalidOperationException(\"A required query parameter returned null from ToString().\")");
    }

    [TestMethod]
    public void ParameterSerializer_ObjectOptional_DoesNotUseNullForgivingToString()
    {
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "object" },
            isRequired: false);

        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        result.Should().ContainSingle()
            .Which.Value.Should().Be("param.ToString()");
    }

    [TestMethod]
    public void ParameterSerializer_ObjectRequiredButNullable_PreservesNullValue()
    {
        var parameter = CreateQueryParameter(
            TypeData.Default with { CSharpTypeRaw = "object", CSharpTypeNullability = true, IsNullable = true },
            isRequired: true);

        var result = ParameterSerializer.SerializeQueryParameter(parameter);

        result.Should().ContainSingle()
            .Which.Value.Should().Be("param?.ToString()");
    }
}
