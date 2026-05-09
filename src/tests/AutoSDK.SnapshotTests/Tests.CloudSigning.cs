using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    public Task CloudSigningHelpers_GeneratesProviderSigningShape()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Cloud Signing
  version: 1.0.0
paths:
  /model/{modelId}/invoke:
    post:
      operationId: invokeBedrockModel
      x-autosdk-cloud-signing:
        provider: aws-sigv4
        region: us-east-1
        service: bedrock
      security:
        - bearerAuth: []
      parameters:
        - name: modelId
          in: path
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              additionalProperties:
                type: string
      responses:
        '200':
          description: Inference response
          content:
            application/json:
              schema:
                type: object
                additionalProperties:
                  type: string
  /azure/chat/completions:
    post:
      operationId: createAzureChatCompletion
      x-autosdk-cloud-signing:
        provider: azure
        apiKeyHeaderName: api-key
        tokenScope: https://cognitiveservices.azure.com/.default
      security:
        - azureApiKey: []
        - azureBearer: []
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                prompt:
                  type: string
      responses:
        '200':
          description: Chat response
          content:
            application/json:
              schema:
                type: object
                properties:
                  output:
                    type: string
components:
  securitySchemes:
    bearerAuth:
      type: http
      scheme: bearer
    azureApiKey:
      type: apiKey
      in: header
      name: api-key
    azureBearer:
      type: http
      scheme: bearer
""";

        return CheckSourceAsync<SdkGenerator>(
            JsonSerializerType.SystemTextJson,
            [
                new CustomAdditionalText(
                    path: "cloud-signing.yaml",
                    text: spec),
            ],
            callerName: nameof(CloudSigningHelpers_GeneratesProviderSigningShape),
            globalOptions: new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ClassName"] = "CloudClient",
                ["build_property.AutoSDK_GenerateCloudSigningHelpers"] = "true",
                ["build_property.AutoSDK_CloudSigningHelperClassName"] = "CloudRequestSigner",
            },
            additionalGenerators: [new CliGenerator()]);
    }
}
