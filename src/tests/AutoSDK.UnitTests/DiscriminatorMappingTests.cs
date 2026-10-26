using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class DiscriminatorMappingTests
{
    [TestMethod]
    [DataRow(false, false)]
    [DataRow(true, false)]
    [DataRow(false, true)]
    [DataRow(true, true)]
    public void DiscriminatorMapping_MatchesExactSchemaIdentity(bool stableNames, bool renameType)
    {
        var yaml = """
        openapi: 3.0.3
        info: {title: Test, version: '1.0'}
        paths: {}
        components:
          schemas:
            Response:
              type: object
              properties:
                included:
                  type: array
                  items:
                    oneOf:
                      - $ref: '#/components/schemas/AppEncryptionDeclaration'
                      - $ref: '#/components/schemas/App'
                    discriminator:
                      propertyName: type
                      mapping:
                        declarations: '#/components/schemas/AppEncryptionDeclaration'
                        apps: '#/components/schemas/App'
            AppEncryptionDeclaration:
              type: object
              properties:
                type: {type: string}
            App:
              x-fern-type-name: RenamedApplication
              type: object
              properties:
                type: {type: string}
        """;
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerContext = "G.SourceGenerationContext",
            StableAnonymousUnionNames = stableNames,
            UseExtensionNaming = renameType,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var union = data.AnyOfs.Should().ContainSingle().Subject;
        union.Properties.Select(property => property.DiscriminatorJsonValue)
            .Should().Equal("declarations", "apps");
        union.Properties.Select(property => property.Name).Should().OnlyHaveUniqueItems();
        union.Properties[1].Type.CSharpTypeWithoutNullability.Should().Be(
            renameType ? "global::G.RenamedApplication" : "global::G.App");
    }
}
