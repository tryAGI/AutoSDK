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
        methodCode.Should().Contain("byte[] file,");
        methodCode.Should().Contain("global::System.IO.Stream file,");
        methodCode.Should().Contain("file = file ?? throw new global::System.ArgumentNullException(nameof(file));");
        methodCode.Should().Contain("File = global::System.Array.Empty<byte>(),");
        methodCode.Should().Contain("Filename = filename,");
        methodCode.Should().Contain("var __contentFile = new global::System.Net.Http.StreamContent(file);");
        methodCode.Should().Contain("supportsRetry: false");
        methodCode.Should().NotContain(".Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture)");
        methodCode.Should().NotContain("$\"{request.Diarize}");
        methodCode.Should().NotContain("$\"{request.NumSpeakers}");
        methodCode.Should().NotContain("$\"{request.Temperature}");
    }

    [TestMethod]
    public void MultipartFormData_GeneratesStreamOverloadForRepeatedFileParts()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Multipart
  version: 1.0.0
paths:
  /v1/voices:
    post:
      operationId: createVoice
      requestBody:
        required: true
        content:
          multipart/form-data:
            schema:
              type: object
              required:
                - files
              properties:
                files:
                  type: array
                  items:
                    type: string
                    format: binary
                name:
                  type: string
      responses:
        '204':
          description: ok
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Single(x => x.NotAsyncMethodName == "CreateVoice");
        var methodCode = Sources.GenerateEndPoint(method);

        methodCode.Should().Contain("global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,");
        methodCode.Should().Contain("global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,");
        methodCode.Should().Contain("Files = new global::System.Collections.Generic.List<byte[]>(),");
        methodCode.Should().Contain("for (var __iFiles = 0; __iFiles < files.Count; __iFiles++)");
        methodCode.Should().Contain("var __contentFiles = new global::System.Net.Http.StreamContent(files[__iFiles]);");
        methodCode.Should().Contain("filesFileNames != null &&");
        methodCode.Should().Contain(": $\"file{__iFiles}.bin\";");
        methodCode.Should().Contain("supportsRetry: false");
    }
}
