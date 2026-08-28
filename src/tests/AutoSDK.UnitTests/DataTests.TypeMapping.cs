using AutoSDK.Generation;
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

    [TestMethod]
    public void TypeMapper_CollapsesNullableOneOfArrayItemsAndPreservesElementNullability()
    {
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: nullable-oneof
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                HashMap:
                                  type: object
                                  additionalProperties: true
                                AddPayload:
                                  type: object
                                  properties:
                                    metadatas:
                                      type: array
                                      items:
                                        oneOf:
                                          - type: 'null'
                                          - $ref: '#/components/schemas/HashMap'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(
            ((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var generatedModels = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModels.Should().Contain(
            "global::System.Collections.Generic.IList<global::G.HashMap?>? Metadatas");
        generatedModels.Should().NotContain("OneOf<object, global::G.HashMap>");
    }
}
