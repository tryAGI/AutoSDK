using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class OpenApiSchemaExtensionsTests
{
    [TestMethod]
    public void IsNullableAnyOf_RequiresExactlyOneNullVariant()
    {
        var nullable = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        var twoNulls = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.Null },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        var twoValues = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Integer },
            ],
        };

        nullable.IsNullableAnyOf().Should().BeTrue();
        twoNulls.IsNullableAnyOf().Should().BeFalse();
        twoValues.IsNullableAnyOf().Should().BeFalse();
    }

    [TestMethod]
    public void AnyOfOneOfAndAllOf_RequireNonEmptyVariants()
    {
        var anyOf = new OpenApiSchema { AnyOf = [new OpenApiSchema()] };
        var oneOf = new OpenApiSchema { OneOf = [new OpenApiSchema()] };
        var allOf = new OpenApiSchema { AllOf = [new OpenApiSchema()] };
        var empty = new OpenApiSchema();

        anyOf.IsAnyOf().Should().BeTrue();
        oneOf.IsOneOf().Should().BeTrue();
        allOf.IsAllOf().Should().BeTrue();
        empty.IsAnyOf().Should().BeFalse();
        empty.IsOneOf().Should().BeFalse();
        empty.IsAllOf().Should().BeFalse();
    }
}
