using AutoSDK.Generation;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow("3.0.3")]
    [DataRow("3.1.0")]
    public void GenerateClassModel_WithReferencedUnionDictionaryValues_PreservesValueTypes(
        string openApiVersion)
    {
        var yaml = $$"""
                     openapi: {{openApiVersion}}
                     info:
                       title: Typed union dictionaries
                       version: 1.0.0
                     paths: {}
                     components:
                       schemas:
                         Survey:
                           type: object
                           required:
                             - questions
                             - answers
                           properties:
                             questions:
                               type: object
                               additionalProperties:
                                 $ref: '#/components/schemas/Question'
                             answers:
                               type: object
                               additionalProperties:
                                 $ref: '#/components/schemas/Answer'
                             metadata:
                               type: object
                               additionalProperties: true
                         Question:
                           oneOf:
                             - $ref: '#/components/schemas/TextQuestion'
                             - $ref: '#/components/schemas/ChoiceQuestion'
                           discriminator:
                             propertyName: type
                             mapping:
                               text: '#/components/schemas/TextQuestion'
                               choice: '#/components/schemas/ChoiceQuestion'
                         Answer:
                           anyOf:
                             - $ref: '#/components/schemas/TextAnswer'
                             - $ref: '#/components/schemas/ChoiceAnswer'
                           discriminator:
                             propertyName: type
                             mapping:
                               text: '#/components/schemas/TextAnswer'
                               choice: '#/components/schemas/ChoiceAnswer'
                         TextQuestion:
                           type: object
                           required: [type, prompt]
                           properties:
                             type:
                               type: string
                               enum: [text]
                             prompt:
                               type: string
                         ChoiceQuestion:
                           type: object
                           required: [type, prompt, options]
                           properties:
                             type:
                               type: string
                               enum: [choice]
                             prompt:
                               type: string
                             options:
                               type: array
                               items:
                                 type: string
                         TextAnswer:
                           type: object
                           required: [type, value]
                           properties:
                             type:
                               type: string
                               enum: [text]
                             value:
                               type: string
                         ChoiceAnswer:
                           type: object
                           required: [type, values]
                           properties:
                             type:
                               type: string
                               enum: [choice]
                             values:
                               type: array
                               items:
                                 type: string
                     """;

        var settings = DefaultSettings with
        {
            TargetFramework = "net10.0",
            GenerateModels = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "TestNamespace.SourceGenerationContext",
        };

        var data = PrepareOpenApi(useDataPrepareFacade: true, yaml, settings);
        var survey = data.Classes.Single(x => x.ClassName == "Survey");
        var generatedModel = Sources.GenerateModel(survey);

        generatedModel.Should().Contain(
            "public required global::System.Collections.Generic.Dictionary<string, global::TestNamespace.Question> Questions { get; set; }");
        generatedModel.Should().Contain(
            "public required global::System.Collections.Generic.Dictionary<string, global::TestNamespace.Answer> Answers { get; set; }");
        generatedModel.Should().Contain("public object? Metadata { get; set; }");

        data.Types.Select(static type => type.CSharpTypeWithoutNullability).Should().Contain(
        [
            "global::System.Collections.Generic.Dictionary<string, global::TestNamespace.Question>",
            "global::System.Collections.Generic.Dictionary<string, global::TestNamespace.Answer>",
            "global::TestNamespace.Question",
            "global::TestNamespace.Answer",
        ]);
    }
}
