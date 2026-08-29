using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class RequiredValueTypeRequestBodyTests
{
    [TestMethod]
    public void RequiredAllOfRequestBody_DoesNotEmitReferenceTypeNullGuard()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            ClassName = "Api",
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net10.0",
        };
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: Required value-type body
                              version: 1.0.0
                            paths:
                              /videos:
                                post:
                                  operationId: createVideo
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/VideoRequest'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            type: string
                            components:
                              schemas:
                                VideoRequest:
                                  allOf:
                                    - type: object
                                      properties:
                                        model:
                                          type: string
                                          enum: [video-v1]
                                    - $ref: '#/components/schemas/CommonRequest'
                                CommonRequest:
                                  type: object
                                  properties:
                                    prompt:
                                      type: string
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var endPoint = data.Methods.Should().ContainSingle().Subject;
        var generatedCode = Sources.GenerateEndPoint(endPoint);

        endPoint.RequestType.IsValueType.Should().BeTrue();
        generatedCode.Should().Contain("global::G.VideoRequest request");
        generatedCode.Should().NotContain(
            "request = request ?? throw new global::System.ArgumentNullException(nameof(request));");
    }
}
