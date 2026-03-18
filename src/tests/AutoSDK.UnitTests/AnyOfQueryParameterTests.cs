using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class AnyOfQueryParameterTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "Api",
    };

    [TestMethod]
    public void OptionalAnyOfQueryParameter_DoesNotSendEmptyValue()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      parameters:
        - name: expand
          in: query
          required: false
          schema:
            anyOf:
              - type: string
              - type: array
                items:
                  type: string
      responses:
        '200':
          description: OK
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // Optional AnyOf params should use ?.ToString() — NOT ?.ToString() ?? string.Empty
        // which would send ?expand= (empty value) instead of skipping the param
        generatedCode.Should().Contain(@"AddOptionalParameter(""expand"", expand?.ToString())");
        generatedCode.Should().NotContain(@"expand?.ToString() ?? string.Empty");
    }

    [TestMethod]
    public void RequiredAnyOfQueryParameter_UsesNullCoalescing()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      parameters:
        - name: filter
          in: query
          required: true
          schema:
            anyOf:
              - type: string
              - type: integer
      responses:
        '200':
          description: OK
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // Required AnyOf params need ?? string.Empty for null safety with AddRequiredParameter
        generatedCode.Should().Contain("AddRequiredParameter");
        generatedCode.Should().Contain(".ToString() ?? string.Empty");
    }

    private static EndPoint LoadEndPoint(string yaml)
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        return data.Methods.Single();
    }
}
