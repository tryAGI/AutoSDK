using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class SanitizeNumericConstraintsTests
{
    [TestMethod]
    public void StripExtremeMinimum_ExceedsLongRange()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TestSchema"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["seed"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Minimum = "-9223372036854776000",
                                Maximum = "9223372036854776000",
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeNumericConstraints();

        var seedSchema = (OpenApiSchema)document.Components.Schemas["TestSchema"].Properties!["seed"];
        Assert.IsNull(seedSchema.Minimum, "Minimum exceeding long range should be stripped");
        Assert.IsNull(seedSchema.Maximum, "Maximum exceeding long range should be stripped");
    }

    [TestMethod]
    public void PreserveValidMinMax_WithinLongRange()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TestSchema"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["count"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Minimum = "0",
                                Maximum = "100",
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeNumericConstraints();

        var countSchema = (OpenApiSchema)document.Components.Schemas["TestSchema"].Properties!["count"];
        Assert.AreEqual("0", countSchema.Minimum, "Valid minimum should be preserved");
        Assert.AreEqual("100", countSchema.Maximum, "Valid maximum should be preserved");
    }

    [TestMethod]
    public void StripExtremeMinMax_Int32Format()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TestSchema"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["value"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Format = "int32",
                                Minimum = "-3000000000",
                                Maximum = "3000000000",
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeNumericConstraints();

        var schema = (OpenApiSchema)document.Components.Schemas["TestSchema"].Properties!["value"];
        Assert.IsNull(schema.Minimum, "Minimum exceeding int32 range should be stripped");
        Assert.IsNull(schema.Maximum, "Maximum exceeding int32 range should be stripped");
    }

    [TestMethod]
    public void StripExtremeExclusiveMinMax()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TestSchema"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["value"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                ExclusiveMinimum = "-9223372036854776000",
                                ExclusiveMaximum = "9223372036854776000",
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeNumericConstraints();

        var schema = (OpenApiSchema)document.Components.Schemas["TestSchema"].Properties!["value"];
        Assert.IsNull(schema.ExclusiveMinimum, "ExclusiveMinimum exceeding long range should be stripped");
        Assert.IsNull(schema.ExclusiveMaximum, "ExclusiveMaximum exceeding long range should be stripped");
    }

    [TestMethod]
    public void IgnoreNonIntegerTypes()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TestSchema"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["ratio"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Number,
                                Minimum = "-999999999999999999999",
                                Maximum = "999999999999999999999",
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeNumericConstraints();

        var schema = (OpenApiSchema)document.Components.Schemas["TestSchema"].Properties!["ratio"];
        Assert.AreEqual("-999999999999999999999", schema.Minimum, "Non-integer minimum should be preserved");
        Assert.AreEqual("999999999999999999999", schema.Maximum, "Non-integer maximum should be preserved");
    }
}
