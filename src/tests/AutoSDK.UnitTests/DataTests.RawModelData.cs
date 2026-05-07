using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void GenerateClassModel_WithRawModelData_UsesTypedJsonExtensionData(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Raw Model Data
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                ClosedModel:
                                  type: object
                                  additionalProperties: false
                                  properties:
                                    name:
                                      type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateRawModelData = true,
            GenerateModels = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "TestNamespace.SourceGenerationContext",
        };

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var model = data.Classes.Single(x => x.ClassName == "ClosedModel");
        var generatedModel = Sources.Class(model).Text;
        var generatedJson = Sources.ClassJsonExtensions(model).Text;

        generatedModel.Should().Contain("[global::System.Text.Json.Serialization.JsonExtensionData]");
        generatedModel.Should().Contain("public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties");
        generatedModel.Should().Contain("Raw JSON properties that are not explicitly defined in the schema");
        generatedModel.Should().NotContain("IDictionary<string, object> AdditionalProperties");
        generatedJson.Should().Contain("public static global::TestNamespace.ClosedModel? FromRawUnchecked(");
        generatedJson.Should().Contain("public string ToRawJson(");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void GenerateClassModel_WithRawModelData_AvoidsAdditionalPropertiesNameCollision(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Raw Model Data Collision
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                CollisionModel:
                                  type: object
                                  properties:
                                    additionalProperties:
                                      type: boolean
                            """;

        var settings = DefaultSettings with
        {
            GenerateRawModelData = true,
            GenerateModels = true,
        };

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var model = data.Classes.Single(x => x.ClassName == "CollisionModel");
        var generatedModel = Sources.Class(model).Text;

        generatedModel.Should().Contain("public bool? AdditionalProperties { get; set; }");
        generatedModel.Should().Contain("public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties2");
    }
}
