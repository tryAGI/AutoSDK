using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.TypeMapping;

namespace AutoSDK.UnitTests;

[TestClass]
public class UnionGenerationRegressionTests
{
    [TestMethod]
    public void ObjectVariant_DoesNotUseNullableValueMember()
    {
        // A referenced object can carry IsValueType from its enclosing union.
        // The emitted CustomTool remains a class and has no Value member.
        var customTool = (TypeData.Default with
        {
            CSharpTypeRaw = "global::G.CustomTool",
            Namespace = "G",
            GeneratedNamespace = "G",
            IsValueType = true,
        }).WithCSharpComputedValues();
        var count = (TypeData.Default with
        {
            CSharpTypeRaw = "int",
            Namespace = "G",
            GeneratedNamespace = "G",
            IsValueType = true,
        }).WithCSharpComputedValues();
        var properties = ImmutableArray.Create(
            PropertyData.Default with { Name = "Custom", ParameterName = "custom", Type = customTool },
            PropertyData.Default with { Name = "Count", ParameterName = "count", Type = count })
            .AsEquatableArray();
        var union = new AnyOfData(
            SubType: "OneOf",
            Count: 2,
            DiscriminatorType: null,
            DiscriminatorPropertyName: null,
            DiscriminatorPropertyTypeName: null,
            DiscriminatorPropertyIsEnum: false,
            IsTrimming: true,
            Namespace: "G",
            Name: "Tool",
            Summary: string.Empty,
            Properties: properties,
            Settings: EmitterSettings.Default with { Namespace = "G", TargetFramework = "net10.0" });

        var model = Sources.GenerateAnyOf(union);
        var converter = Sources.GenerateAnyOfJsonConverter(union);

        model.Should().Contain("PickCustom() => IsCustom");
        model.Should().Contain("? Custom!");
        model.Should().NotContain("Custom!.Value");
        model.Should().Contain("Count!.Value");
        converter.Should().Contain("value.Custom!, typeInfo");
        converter.Should().NotContain("value.Custom!.Value");
        converter.Should().Contain("value.Count!.Value, typeInfo");
    }

    [TestMethod]
    public void CollidingResponseDiscriminators_ReferenceEmittedModels()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            ClassName = "Api",
            TargetFramework = "net10.0",
            GenerateModels = true,
            GenerateSdk = true,
            GenerateJsonSerializerContextTypes = true,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: CollidingDiscriminators
                              version: 1.0.0
                            paths:
                              /tools:
                                delete:
                                  operationId: removeTool
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            oneOf:
                                              - $ref: '#/components/schemas/ToolA'
                                              - $ref: '#/components/schemas/ToolB'
                                            discriminator:
                                              propertyName: type
                                              mapping:
                                                a: '#/components/schemas/ToolA'
                                                b: '#/components/schemas/ToolB'
                                    '409':
                                      description: conflict
                                      content:
                                        application/json:
                                          schema:
                                            oneOf:
                                              - $ref: '#/components/schemas/ConflictA'
                                              - $ref: '#/components/schemas/ConflictB'
                                            discriminator:
                                              propertyName: error
                                              mapping:
                                                a: '#/components/schemas/ConflictA'
                                                b: '#/components/schemas/ConflictB'
                            components:
                              schemas:
                                ToolA:
                                  type: object
                                  properties:
                                    type:
                                      type: string
                                      enum: [a]
                                ToolB:
                                  type: object
                                  properties:
                                    type:
                                      type: string
                                      enum: [b]
                                ConflictA:
                                  type: object
                                  properties:
                                    error:
                                      type: string
                                      enum: [a]
                                ConflictB:
                                  type: object
                                  properties:
                                    error:
                                      type: string
                                      enum: [b]
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var emittedClasses = data.Classes
            .Select(model => model.GlobalClassName)
            .ToHashSet(StringComparer.Ordinal);
        var emittedEnums = data.Enums
            .Select(model => model.GlobalClassName)
            .ToHashSet(StringComparer.Ordinal);
        var unions = data.AnyOfs
            .Where(union => union.DiscriminatorType != null)
            .ToArray();

        unions.Should().HaveCount(2);
        unions.Should().OnlyContain(union => union.DiscriminatorPropertyIsEnum);
        unions.Should().Contain(union => union.DiscriminatorPropertyTypeName !=
            $"{union.DiscriminatorType!.Value.CSharpTypeWithoutNullability}{union.DiscriminatorPropertyName}");
        foreach (var union in unions)
        {
            emittedClasses.Should().Contain(union.DiscriminatorType!.Value.CSharpTypeWithoutNullability);
            if (union.DiscriminatorPropertyIsEnum)
            {
                emittedEnums.Should().Contain(union.DiscriminatorPropertyTypeName);
                var generatedModel = Sources.GenerateAnyOf(union);
                var generatedConverter = Sources.GenerateAnyOfJsonConverter(union);
                generatedModel.Should().Contain($"{union.DiscriminatorPropertyTypeName}?");
                generatedConverter.Should().Contain($"{union.DiscriminatorPropertyTypeName}.");
            }
        }
        foreach (var discriminator in data.Classes.Where(model => model.ClassName.Contains("Discriminator", StringComparison.Ordinal)))
        {
            foreach (var property in discriminator.Properties.Where(property => property.Type.IsEnum))
            {
                emittedEnums.Should().Contain(property.Type.CSharpTypeWithoutNullability);
            }
        }
    }
}
