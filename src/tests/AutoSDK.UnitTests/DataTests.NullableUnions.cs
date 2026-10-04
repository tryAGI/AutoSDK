using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Data = AutoSDK.Generation.Data;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow("oneOf", 0, false)]
    [DataRow("oneOf", 1, false)]
    [DataRow("oneOf", 2, false)]
    [DataRow("oneOf", 0, true)]
    [DataRow("oneOf", 1, true)]
    [DataRow("oneOf", 3, true)]
    [DataRow("anyOf", 0, false)]
    [DataRow("anyOf", 1, false)]
    [DataRow("anyOf", 2, false)]
    [DataRow("anyOf", 0, true)]
    [DataRow("anyOf", 1, true)]
    [DataRow("anyOf", 3, true)]
    public void MultiValueNullableUnion_PreservesConcreteVariantsAndRequiredNullability(
        string keyword, int nullIndex, bool thirdValue)
    {
        var spec = CreateNullableUnionSpec(keyword, nullIndex, thirdValue);
        var data = Data.Prepare(((spec, DefaultSettings), GlobalSettings: DefaultSettings));
        var property = data.Classes.Single(x => x.ClassName == "Request").Properties.Single();
        var variants = property.Type.SubTypes.Select(x => x.Unbox<TypeData>()).ToArray();

        variants.Should().HaveCount(thirdValue ? 3 : 2);
        (keyword == "oneOf" ? property.Type.OneOfCount : property.Type.AnyOfCount)
            .Should().Be(variants.Length);
        data.AnyOfs.Where(x => string.IsNullOrEmpty(x.Name)).Should().ContainSingle()
            .Which.Count.Should().Be(variants.Length);
        variants.Select(x => x.CSharpTypeRaw).Should().NotContain("object");
        variants[0].IsEnum.Should().BeTrue();
        variants[1].CSharpTypeRaw.Should().Be("global::G.Config");
        if (thirdValue)
        {
            variants[2].CSharpTypeRaw.Should().Be("int");
        }
        property.Type.IsNullable.Should().BeTrue();
        property.Type.CSharpType.Should().EndWith("?");
        property.Type.CSharpType.Should().StartWith($"global::G.{(keyword == "oneOf" ? "OneOf" : "AnyOf")}<");

        // Equivalent nullable syntax must preserve public branch names/order and generic arity.
        var legacy = JsonNode.Parse(CreateNullableUnionSpec(keyword, -1, thirdValue))!;
        legacy["openapi"] = "3.0.3";
        legacy["components"]!["schemas"]!["Request"]!["properties"]!["choice"]!["nullable"] = true;
        var legacyData = Data.Prepare(((legacy.ToJsonString(), DefaultSettings), GlobalSettings: DefaultSettings));
        var legacyType = legacyData.Classes.Single(x => x.ClassName == "Request").Properties.Single().Type;
        property.Type.CSharpType.Should().Be(legacyType.CSharpType);
    }

    [TestMethod]
    [DataRow("oneOf")]
    [DataRow("anyOf")]
    public void MultiValueNullableUnion_PreservesNamedReferenceAndNullableArrayItems(string keyword)
    {
        var document = JsonNode.Parse(CreateNullableUnionSpec(keyword, 0, false))!;
        var schemas = document["components"]!["schemas"]!;
        var choice = schemas["Request"]!["properties"]!["choice"]!.DeepClone();
        schemas["Choice"] = choice;
        schemas["Request"]!["properties"]!["choice"] = JsonNode.Parse("""{"$ref":"#/components/schemas/Choice"}""");
        schemas["Request"]!["properties"]!["items"] = new JsonObject
        {
            ["type"] = "array",
            ["items"] = choice.DeepClone(),
        };
        var data = Data.Prepare(((document.ToJsonString(), DefaultSettings), GlobalSettings: DefaultSettings));
        var request = data.Classes.Single(x => x.ClassName == "Request");
        var property = request.Properties.Single(x => x.Id == "choice");
        property.Type.CSharpType.Should().Be("global::G.Choice?");
        property.Type.SubTypes.Should().HaveCount(2);
        property.Type.SubTypes.Select(x => x.Unbox<TypeData>().CSharpTypeRaw).Should().NotContain("object");
        var items = request.Properties.Single(x => x.Id == "items");
        items.Type.CSharpType.Should().Contain($"{(keyword == "oneOf" ? "OneOf" : "AnyOf")}<").And.Contain(">?>");
    }

    [TestMethod]
    [DataRow("oneOf")]
    [DataRow("anyOf")]
    public void MultiValueNullableUnion_RetainsActualUnconstrainedObjectAlternative(string keyword)
    {
        var document = JsonNode.Parse(CreateNullableUnionSpec(keyword, 1, false))!;
        var variants = document["components"]!["schemas"]!["Request"]!["properties"]!["choice"]![keyword]!.AsArray();
        variants.Add(new JsonObject());
        var data = Data.Prepare(((document.ToJsonString(), DefaultSettings), GlobalSettings: DefaultSettings));
        var property = data.Classes.Single(x => x.ClassName == "Request").Properties.Single();
        property.Type.SubTypes.Should().HaveCount(3);
        property.Type.SubTypes.Select(x => x.Unbox<TypeData>().CSharpTypeRaw).Should().ContainSingle(x => x == "object");
    }

    [TestMethod]
    public void NullableUnion_DoesNotCollapseMultiValueOrEmptyConcreteSet()
    {
        var union = new OpenApiSchema
        {
            OneOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Integer },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        union.IsNullable().Should().BeTrue();
        union.IsNullableOneOf().Should().BeFalse();
        union.IsOneOf().Should().BeTrue();
        union.Type = JsonSchemaType.String;
        union.IsNullable().Should().BeFalse();
        var twoNulls = new OpenApiSchema
        {
            OneOf = [new OpenApiSchema { Type = JsonSchemaType.Null }, new OpenApiSchema { Type = JsonSchemaType.Null }],
        };
        twoNulls.IsNullable().Should().BeFalse();
        twoNulls.IsNullableOneOf().Should().BeFalse();
    }

    [TestMethod]
    [DataRow("oneOf")]
    [DataRow("anyOf")]
    public async Task MultiValueNullableUnion_ModelSnapshot(string keyword)
    {
        var data = Data.Prepare(((CreateNullableUnionSpec(keyword, 1, false), DefaultSettings), GlobalSettings: DefaultSettings));
        await Verify(string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x))))
            .UseDirectory("Snapshots/NullableUnions")
            .UseFileName(keyword);
    }

    private static string CreateNullableUnionSpec(string keyword, int nullIndex, bool thirdValue)
    {
        var variants = new JsonArray
        {
            JsonNode.Parse("""{"type":"string","enum":["auto"]}"""),
            JsonNode.Parse("""{"$ref":"#/components/schemas/Config"}"""),
        };
        if (thirdValue)
        {
            variants.Add(JsonNode.Parse("""{"type":"integer"}"""));
        }
        if (nullIndex >= 0)
        {
            variants.Insert(nullIndex, JsonNode.Parse("""{"type":"null"}"""));
        }
        var document = JsonNode.Parse("""
            {"openapi":"3.1.0","info":{"title":"Nullable union","version":"1.0.0"},"paths":{},
             "components":{"schemas":{
               "Config":{"type":"object","properties":{"workflow_name":{"type":"string"}}},
               "Request":{"type":"object","required":["choice"],"properties":{}}}}}
            """)!;
        document["components"]!["schemas"]!["Request"]!["properties"]!["choice"] = new JsonObject { [keyword] = variants };
        return document.ToJsonString();
    }
}
