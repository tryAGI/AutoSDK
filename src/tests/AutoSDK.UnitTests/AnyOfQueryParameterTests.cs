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
    public void OptionalAnyOfQueryParameter_WithArrayVariant_UsesRepeatedValues()
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
            oneOf:
              - type: boolean
              - type: array
                items:
                  type: string
      responses:
        '200':
          description: OK
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        generatedCode.Should().Contain(@"AddOptionalParameter(""expand"", expand?.Match(");
        generatedCode.Should().Contain("static x => (global::System.Collections.Generic.IEnumerable<string?>)new string?[] { x?.ToString().ToLowerInvariant() }");
        generatedCode.Should().Contain("global::System.Linq.Enumerable.Select(x, static item => item)");
        generatedCode.Should().Contain("validate: false), delimiter: \",\", explode: true)");
        generatedCode.Should().NotContain(@"expand?.ToString()");
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
