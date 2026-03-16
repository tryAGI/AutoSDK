using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class InferLargeIntegerFormatsTests
{
    [TestMethod]
    public void InferInt64FromLargeDefault()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TimeInterval"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["to"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Default = JsonValue.Create(4000000000000L),
                            },
                        },
                    },
                },
            },
        };

        document.InferLargeIntegerFormats();

        var schema = (OpenApiSchema)document.Components.Schemas["TimeInterval"].Properties!["to"];
        Assert.AreEqual("int64", schema.Format);
    }

    [TestMethod]
    public void InferInt64FromNanosecondsDescription()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["GenerateResponse"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["total_duration"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Description = "Time spent generating the response in nanoseconds",
                            },
                        },
                    },
                },
            },
        };

        document.InferLargeIntegerFormats();

        var schema = (OpenApiSchema)document.Components.Schemas["GenerateResponse"].Properties!["total_duration"];
        Assert.AreEqual("int64", schema.Format);
    }

    [TestMethod]
    public void InferInt64InsideNullableAnyOfFromParentDescription()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["FineTuningResponseModel"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["next_max_verification_attempts_reset_unix_ms"] = new OpenApiSchema
                            {
                                Title = "Next Max Verification Attempts Reset Unix Ms",
                                Description = "The next maximum verification attempts reset time in Unix milliseconds.",
                                AnyOf =
                                [
                                    new OpenApiSchema
                                    {
                                        Type = JsonSchemaType.Integer,
                                    },
                                    new OpenApiSchema
                                    {
                                        Type = JsonSchemaType.Null,
                                    },
                                ],
                            },
                        },
                    },
                },
            },
        };

        document.InferLargeIntegerFormats();

        var schema = (OpenApiSchema)document.Components.Schemas["FineTuningResponseModel"].Properties!["next_max_verification_attempts_reset_unix_ms"];
        var integerChild = (OpenApiSchema)schema.AnyOf!.First();
        Assert.AreEqual("int64", integerChild.Format);
    }

    [TestMethod]
    public void PreservePlainIntWhenNoLargeValueHintsExist()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["Paging"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["page"] = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Integer,
                                Default = JsonValue.Create(1),
                            },
                        },
                    },
                },
            },
        };

        document.InferLargeIntegerFormats();

        var schema = (OpenApiSchema)document.Components.Schemas["Paging"].Properties!["page"];
        Assert.IsTrue(string.IsNullOrEmpty(schema.Format));
    }
}
