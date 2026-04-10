using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class SystemNetHttpJsonTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net10.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        GenerateJsonSerializerContextTypes = true,
        GenerateMethodsUsingSystemNetHttpJson = true,
    };

    [TestMethod]
    public void SystemNetHttpJsonFlag_UsesJsonHelpersForJsonRequestAndResponse()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: HttpJson
  version: 1.0.0
paths:
  /people:
    post:
      operationId: createPerson
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Person'
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Person'
  /flag:
    get:
      operationId: getFlag
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: boolean
components:
  schemas:
    Person:
      type: object
      required: [name]
      properties:
        name:
          type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var createPersonMethod = data.Methods.Single(x => x.NotAsyncMethodName == "CreatePerson");
        var getFlagMethod = data.Methods.Single(x => x.NotAsyncMethodName == "GetFlag");

        var createPersonMethodCode = Sources.Method(createPersonMethod).Text;
        var getFlagMethodCode = Sources.Method(getFlagMethod).Text;
        var polyfillCode = Sources.Polyfills((CSharpSettings)createPersonMethod.Settings).Text;

        createPersonMethodCode.Should().Contain("AutoSdkPolyfills.CreateJsonContent(");
        getFlagMethodCode.Should().Contain("AutoSdkPolyfills.ReadFromJsonAsync<bool?>(__response.Content, JsonSerializerOptions, __effectiveCancellationToken)");
        polyfillCode.Should().Contain("global::System.Net.Http.Json.JsonContent.Create(");
        polyfillCode.Should().Contain("global::System.Net.Http.Json.HttpContentJsonExtensions.ReadFromJsonAsync");
    }

    [TestMethod]
    public void SystemNetHttpJsonFlag_FallbackPolyfillsAvoidFrameworkSpecificNamedArguments()
    {
        var polyfillCode = Sources.Polyfills((CSharpSettings)DefaultSettings).Text;

        polyfillCode.Should().NotContain("jsonSerializerContext:");
        polyfillCode.Should().NotContain("mediaType: mediaType");
        polyfillCode.Should().Contain("stringContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(mediaType)");
    }
}
