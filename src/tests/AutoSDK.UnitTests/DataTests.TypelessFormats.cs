using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

/// <summary>
/// A schema that gives a <c>format</c> and no <c>type</c>.
/// </summary>
/// <remarks>
/// Weaviate's spec is where this came from: it declares <c>"type": ["string", "null"]</c> on seven
/// properties, which is JSON Schema syntax, inside a <c>swagger: "2.0"</c> document, where the 2.0
/// schema object has no array form. The reader cannot represent it and hands over a schema whose
/// type is simply absent while <c>format: date-time</c> survives - and the mapper used to throw
/// <c>NotSupportedException</c> on the first one it reached, which aborted the whole generation.
/// </remarks>
public partial class DataTests
{
    private SchemaContext ContextForFormat(string format, string name) =>
        new(
            DefaultSettings.ToSchemaContextSettings(),
            new OpenApiSchema { Format = format },
            name,
            "class");

    [TestMethod]
    public void TypeMapper_InfersStringFromADateTimeFormatWithNoType()
    {
        // This exact schema - `DBUserInfo.createdAt` - threw before.
        CSharpTypeMapper.GetCSharpType(ContextForFormat("date-time", "WeaviateDbUserCreatedAt"))
            .Should().Be("global::System.DateTime");
    }

    [TestMethod]
    public void TypeMapper_InfersUuidAndByteFromFormatWithNoType()
    {
        CSharpTypeMapper.GetCSharpType(ContextForFormat("uuid", "TypelessUuid"))
            .Should().Be("global::System.Guid");
        CSharpTypeMapper.GetCSharpType(ContextForFormat("byte", "TypelessByte"))
            .Should().Be("byte[]");
    }

    [TestMethod]
    public void TypeMapper_InfersNumericTypesFromFormatWithNoType()
    {
        CSharpTypeMapper.GetCSharpType(ContextForFormat("int64", "TypelessInt64"))
            .Should().Be("long");
        CSharpTypeMapper.GetCSharpType(ContextForFormat("decimal", "TypelessDecimal"))
            .Should().Be("decimal");
    }

    [TestMethod]
    public void TypeMapper_LeavesAFormatNobodyAgreesOnAlone()
    {
        // Inference only covers formats one JSON type can carry. Anything else is not guessed into
        // a type - it becomes `object`, the same answer a schema with no format at all gets.
        //
        // This test is why there is a second fix in the mapper: an unrecognized format used to
        // throw `NotSupportedException` and abort the whole generation, purely because an unknown
        // annotation string was present on a schema that was otherwise the already-handled
        // "no type, no format" case.
        CSharpTypeMapper.GetCSharpType(ContextForFormat("something-vendor-specific", "TypelessOther"))
            .Should().Be("object");
    }

    [TestMethod]
    public void InferTypeFromFormat_IsSilentWhereItHasNothingToSay()
    {
        OpenApiSchemaExtensions.InferTypeFromFormat(null).Should().BeNull();
        OpenApiSchemaExtensions.InferTypeFromFormat(string.Empty).Should().BeNull();
        OpenApiSchemaExtensions.InferTypeFromFormat("   ").Should().BeNull();
        OpenApiSchemaExtensions.InferTypeFromFormat("object").Should().BeNull();
    }

    [TestMethod]
    public void InferTypeFromFormat_DoesNotCareAboutCase()
    {
        OpenApiSchemaExtensions.InferTypeFromFormat("Date-Time").Should().Be("string");
        OpenApiSchemaExtensions.InferTypeFromFormat("INT64").Should().Be("integer");
    }

    [TestMethod]
    public void ToTypeStringWithFormatFallback_PrefersADeclaredTypeOverTheFormat()
    {
        // A declared type wins even when the format suggests another one: the format is the
        // annotation, not the type.
        new OpenApiSchema { Type = JsonSchemaType.String, Format = "int64" }
            .ToTypeStringWithFormatFallback().Should().Be("string");
    }

    [TestMethod]
    public void ToTypeStringWithFormatFallback_StillStripsTheNullFlag()
    {
        // The 3.1 spelling the reader *can* represent, which already worked and must keep working.
        new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Null }
            .ToTypeStringWithFormatFallback().Should().Be("string");
    }
}
