using AutoSDK.Helpers;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Readers.Exceptions;

namespace AutoSDK.UnitTests;

[TestClass]
public class ValidationTests : VerifyBase
{
    [DataTestMethod]
    [DataRow("ai21.yaml")]
    [DataRow("anthropic.yaml")]
    [DataRow("assemblyai.yaml")]
    [DataRow("cohere.yaml")]
    [DataRow("dedoose.json")]
    [DataRow("github.yaml")]
    [DataRow("huggingface.yaml")]
    [DataRow("ipinfo.yaml")]
    [DataRow("langsmith.yaml")]
    [DataRow("leonardo.yaml")]
    [DataRow("ollama.yaml")]
    [DataRow("openai.yaml")]
    [DataRow("petstore.yaml")]
    [DataRow("replicate.yaml")]
    [DataRow("special-cases.yaml")]
    [DataRow("together.yaml")]
    [DataRow("mystic.yaml")]
    [DataRow("twitch.json")]
    [DataRow("heygen.yaml")]
    [DataRow("instill.yaml")]
    [DataRow("ideogram.yaml")]
    [DataRow("google-gemini.yaml")]
    [DataRow("vectara.yaml")]
    [DataRow("mistral.yaml")]
    [DataRow("weaviate.yaml")]
    [DataRow("elevenlabs.json")]
    public async Task Validation(string resourceName)
    {
        var yamlOrJson = new H.Resource(resourceName).AsString();
        
        OpenApiDiagnostic originalDiagnostics;
        try
        {
            _ = new OpenApiStringReader().Read(yamlOrJson, out originalDiagnostics);
        }
        catch (OpenApiUnsupportedSpecVersionException e)
        {
            originalDiagnostics = new OpenApiDiagnostic
            {
                Errors =
                {
                    new OpenApiError(pointer: string.Empty, e.Message),
                }
            };
        }

        if (OpenApi31Support.IsOpenApi31(yamlOrJson))
        {
            yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
        }
        
        _ = new OpenApiStringReader().Read(yamlOrJson, out var newDiagnostics);
        
        await Task.WhenAll(
            Verify(originalDiagnostics.Errors)
                .UseDirectory($"Snapshots/Validation/ConvertedSpecs/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("OriginalErrors"),
            Verify(originalDiagnostics.Warnings)
                .UseDirectory($"Snapshots/Validation/ConvertedSpecs/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("OriginalWarnings"),
            Verify(newDiagnostics.Errors)
                .UseDirectory($"Snapshots/Validation/ConvertedSpecs/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("NewErrors"),
            Verify(newDiagnostics.Warnings)
                .UseDirectory($"Snapshots/Validation/ConvertedSpecs/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("NewWarnings"),
            Verify(yamlOrJson)
                .UseDirectory($"Snapshots/Validation/ConvertedSpecs/{resourceName}")
                .UseFileName("_")
                .AutoVerify()
        );
    }
    
    [TestMethod]
    public void ConvertToOpenApi30_RegexForExclusiveMinimum_Success()
    {
      OpenApi31Support.ConvertYamlToOpenApi30(
        """
        EmbeddingResponseData:
          title: EmbeddingResponseData
          type: object
          properties:
            object:
              type: string
              example: embedding
            embedding:
              type: array
              items:
                type: number
              example:
                - 0.1
                - 0.2
                - 0.3
            index:
              type: integer
              example: 0
          example:
            - object: embedding
              embedding:
                - 0.1
                - 0.2
                - 0.3
              index: 0
            - object: embedding
              embedding:
                - 0.4
                - 0.5
                - 0.6
              index: 1

        """).Should().Be(
        """
        EmbeddingResponseData:
          example:
            embedding:
              - 0.10000000000000001
              - 0.20000000000000001
              - 0.29999999999999999
            index: 0
            object: embedding
          properties:
            embedding:
              example:
                - 0.10000000000000001
                - 0.20000000000000001
                - 0.29999999999999999
              items:
                type: number
              type: array
            index:
              example: 0
              type: integer
            object:
              example: embedding
              type: string
          title: EmbeddingResponseData
          type: object

        """);
      
        OpenApi31Support.ConvertYamlToOpenApi30(
        """
        ImageURLChunk:
          properties:
            type:
              type: string
              enum:
                - image_url
              const: image_url
              title: Type
              default: image_url
            image_url:
              anyOf:
                - $ref: '#/components/schemas/ImageURL'
                - type: string
              title: Image Url
          additionalProperties: false
          type: object
          required:
            - image_url
          title: ImageURLChunk
          description: '{"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0'
        
        """).Should().Be(
        """
        ImageURLChunk:
          additionalProperties: false
          description: '{"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0'
          properties:
            image_url:
              anyOf:
                - $ref: '#/components/schemas/ImageURL'
                - type: string
              title: Image Url
            type:
              default: image_url
              enum:
                - image_url
              title: Type
              type: string
          required:
            - image_url
          title: ImageURLChunk
          type: object

        """);
        
        OpenApi31Support.ConvertYamlToOpenApi30(
        """
        properties:
          index:
            type: integer
          delta:
            $ref: '#/components/schemas/DeltaMessage'
          finish_reason:
            type:
              - string
              - 'null'
            enum:
              - stop
              - length
              - error
              - tool_calls
              - null
        """).Should().Be(
        """
        properties:
          delta:
            $ref: '#/components/schemas/DeltaMessage'
          finish_reason:
            enum:
              - stop
              - length
              - error
              - tool_calls
            nullable: true
            type: string
          index:
            type: integer

        """);

        OpenApi31Support.ConvertYamlToOpenApi30(
          """
          schema:
            anyOf:
              - type: string
              - type: 'null'
            title: Model
          """).Should().Be(
          """
          schema:
            nullable: true
            title: Model
            type: string

          """);
      
        OpenApi31Support.ConvertYamlToOpenApi30(
          """
          weight:
            default: 1
            exclusiveMinimum: 9.223372036854776e+18
            title: Weight
            type: number
          """).Should().Be(
          """
          weight:
            default: 1
            exclusiveMinimum: true
            minimum: 9.2233720368547758E+18
            title: Weight
            type: number
          
          """);
        
        OpenApi31Support.ConvertYamlToOpenApi30(
          """
          epochs:
            anyOf:
              - exclusiveMinimum: 0
                type: number
              - type: 'null'
          """).Should().Be(
          """
          epochs:
            exclusiveMinimum: true
            minimum: 0
            nullable: true
            type: number
          
          """);

        OpenApi31Support.ConvertYamlToOpenApi30(
          """
          properties:
            purpose:
              const: fine-tune
              default: fine-tune
              enum:
                - fine-tune
              title: Purpose
              type: string
          """).Should().Be(
          """
          properties:
            purpose:
              default: fine-tune
              enum:
                - fine-tune
              title: Purpose
              type: string
          
          """);
        
        OpenApi31Support.ConvertYamlToOpenApi30(
          """
          ChatCompletionRequest:
            properties:
              model:
                anyOf:
                  - type: string
                  - type: 'null'
                title: Model
                description: >-
                  ID of the model to use. You can use the [List Available
                  Models](/api/#tag/models/operation/list_models_v1_models_get) API to
                  see all of your available models, or see our [Model
                  overview](/models) for model descriptions.
                examples:
                  - mistral-small-latest
              messages:
                items:
                  oneOf:
                    - $ref: '#/components/schemas/SystemMessage'
                    - $ref: '#/components/schemas/UserMessage'
                    - $ref: '#/components/schemas/AssistantMessage'
                    - $ref: '#/components/schemas/ToolMessage'
                  discriminator:
                    propertyName: role
                    mapping:
                      assistant: '#/components/schemas/AssistantMessage'
                      system: '#/components/schemas/SystemMessage'
                      tool: '#/components/schemas/ToolMessage'
                      user: '#/components/schemas/UserMessage'
                type: array
                title: Messages
                description: >-
                  The prompt(s) to generate completions for, encoded as a list of dict
                  with role and content.
                examples:
                  - - role: user
                      content: Who is the best French painter? Answer in one short sentence.
              response_format:
                $ref: '#/components/schemas/ResponseFormat'
          """).Should().Be(
          """
          ChatCompletionRequest:
            properties:
              messages:
                description: The prompt(s) to generate completions for, encoded as a list of dict with role and content.
                example:
                  - content: Who is the best French painter? Answer in one short sentence.
                    role: user
                items:
                  discriminator:
                    mapping:
                      assistant: '#/components/schemas/AssistantMessage'
                      system: '#/components/schemas/SystemMessage'
                      tool: '#/components/schemas/ToolMessage'
                      user: '#/components/schemas/UserMessage'
                    propertyName: role
                  oneOf:
                    - $ref: '#/components/schemas/SystemMessage'
                    - $ref: '#/components/schemas/UserMessage'
                    - $ref: '#/components/schemas/AssistantMessage'
                    - $ref: '#/components/schemas/ToolMessage'
                title: Messages
                type: array
              model:
                description: ID of the model to use. You can use the [List Available Models](/api/#tag/models/operation/list_models_v1_models_get) API to see all of your available models, or see our [Model overview](/models) for model descriptions.
                example: mistral-small-latest
                nullable: true
                title: Model
                type: string
              response_format:
                $ref: '#/components/schemas/ResponseFormat'
          
          """);
    }
}