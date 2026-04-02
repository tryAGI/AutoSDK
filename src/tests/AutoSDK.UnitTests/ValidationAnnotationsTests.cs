using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class ValidationAnnotationsTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        GenerateModelValidationMethods = true,
        GenerateJsonSerializerContextTypes = true,
    };

    [TestMethod]
    public void ValidationFlag_GeneratesDataAnnotations_AndExclusiveBoundChecks()
    {
        const string yaml = """
openapi: 3.1.0
info:
  title: ValidationAnnotations
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
components:
  schemas:
    Person:
      type: object
      required: [name, age]
      properties:
        name:
          type: string
          minLength: 1
          maxLength: 100
          pattern: '^[A-Z][a-z]+$'
        age:
          type: integer
          minimum: 0
          maximum: 120
        score:
          type: number
          format: double
          exclusiveMinimum: 0
        tags:
          type: array
          minItems: 1
          maxItems: 3
          items:
            type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var model = data.Classes.Single(x => x.ClassName == "Person");

        var modelCode = Sources.Class(model).Text;
        var validationCode = Sources.ClassValidation(model).Text;

        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.Required]");
        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]");
        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.RegularExpression(\"^[A-Z][a-z]+$\")]");
        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.Range(typeof(int), \"0\", \"120\")]");
        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.MinLength(1)]");
        modelCode.Should().Contain("[global::System.ComponentModel.DataAnnotations.MaxLength(3)]");

        validationCode.Should().Contain("public sealed partial class Person : global::System.ComponentModel.DataAnnotations.IValidatableObject");
        validationCode.Should().Contain("Score.HasValue && Score.Value <= global::System.Double.Parse(\"0\", global::System.Globalization.CultureInfo.InvariantCulture)");
        validationCode.Should().Contain("must be a value greater than 0.");
    }
}
