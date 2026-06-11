using AutoSDK.Models;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    public void TypeMapper_TreatsEmptyFormatAsMissingTypeFormat()
    {
        var schema = new OpenApiSchema
        {
            Format = string.Empty,
        };
        var context = new SchemaContext(
            DefaultSettings.ToSchemaContextSettings(),
            schema,
            "SpeechmaticsBlankType",
            "schema");

        CSharpTypeMapper.GetCSharpType(context).Should().Be("object");
        CSharpTypeMapper.IsValueType(context).Should().BeFalse();
    }

    [TestMethod]
    public void TypeMapper_NormalizesMalformedFloatFormat()
    {
        var schema = new OpenApiSchema
        {
            Format = "float,",
        };
        var context = new SchemaContext(
            DefaultSettings.ToSchemaContextSettings(),
            schema,
            "SpeechmaticsSentimentSegmentConfidence",
            "class");

        CSharpTypeMapper.GetCSharpType(context).Should().Be("float");
        CSharpTypeMapper.IsValueType(context).Should().BeTrue();
    }
}
