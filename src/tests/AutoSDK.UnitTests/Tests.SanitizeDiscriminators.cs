using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class SanitizeDiscriminatorsTests
{
    [TestMethod]
    public void RemoveDiscriminator_WhenAllMappingsAreDanglingAndSchemaHasNoComposition()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["TruncationStrategy"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Discriminator = new OpenApiDiscriminator
                        {
                            PropertyName = "type",
                            Mapping = new Dictionary<string, OpenApiSchemaReference>
                            {
                                ["auto"] = new("TruncationStrategyAuto", null, string.Empty),
                                ["none"] = new("TruncationStrategyNone", null, string.Empty),
                            },
                        },
                    },
                },
            },
        };

        document.SanitizeDiscriminators();

        var schema = (OpenApiSchema)document.Components.Schemas["TruncationStrategy"];
        Assert.IsNull(schema.Discriminator);
    }

    [TestMethod]
    public void TrimDanglingMappings_WhenSomeMappingsResolve()
    {
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["Vehicle"] = new OpenApiSchema
                    {
                        OneOf =
                        [
                            new OpenApiSchemaReference("Car", null, string.Empty),
                        ],
                        Discriminator = new OpenApiDiscriminator
                        {
                            PropertyName = "kind",
                            Mapping = new Dictionary<string, OpenApiSchemaReference>
                            {
                                ["car"] = new("Car", null, string.Empty),
                                ["boat"] = new("Boat", null, string.Empty),
                            },
                        },
                    },
                    ["Car"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                    },
                },
            },
        };

        document.SanitizeDiscriminators();

        var schema = (OpenApiSchema)document.Components.Schemas["Vehicle"];
        schema.Discriminator.Should().NotBeNull();
        schema.Discriminator!.PropertyName.Should().Be("kind");
        schema.Discriminator.Mapping.Should().ContainSingle();
        schema.Discriminator.Mapping.Keys.Should().Contain("car");
    }
}
