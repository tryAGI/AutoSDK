using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class MultipartRequestGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        GenerateJsonSerializerContextTypes = true,
    };

    [TestMethod]
    public void MultipartFormData_GeneratesHttpCompatiblePrimitiveAndFileParts()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Multipart
  version: 1.0.0
paths:
  /v1/speech-to-text:
    post:
      operationId: createSpeechToText
      requestBody:
        required: true
        content:
          multipart/form-data:
            schema:
              type: object
              required:
                - model_id
                - file
              properties:
                model_id:
                  type: string
                file:
                  type: string
                  format: binary
                diarize:
                  type: boolean
                num_speakers:
                  type: integer
                temperature:
                  type: number
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: object
                properties:
                  text:
                    type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Single(x => x.NotAsyncMethodName == "CreateSpeechToText");
        var methodCode = Sources.GenerateEndPoint(method);

        methodCode.Should().Contain("(global::System.Convert.ToString(request.Diarize, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()");
        methodCode.Should().Contain("global::System.Convert.ToString(request.NumSpeakers, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty");
        methodCode.Should().Contain("global::System.Convert.ToString(request.Temperature, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty");
        methodCode.Should().Contain("\".m4a\" => \"audio/mp4\"");
        methodCode.Should().Contain("\"application/octet-stream\"");
        methodCode.Should().NotContain(".Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture)");
        methodCode.Should().NotContain("$\"{request.Diarize}");
        methodCode.Should().NotContain("$\"{request.NumSpeakers}");
        methodCode.Should().NotContain("$\"{request.Temperature}");
    }
}
