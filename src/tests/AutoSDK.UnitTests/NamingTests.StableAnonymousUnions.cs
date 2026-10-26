using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    private static SchemaContext[] PrepareAnonymousUnions(bool stable, bool unrelatedFirst = false, bool unrelatedLast = false, bool reverseProperties = false, bool includeCollider = true)
    {
        const string unrelated = """
            OtherResponse:
              type: object
              properties:
                included:
                  type: array
                  items:
                    oneOf:
                      - type: string
                      - type: integer

        """;
        var yaml = """
        openapi: 3.0.3
        info: {title: Test, version: '1.0'}
        paths: {}
        components:
          schemas:
        """ + "\n" + (unrelatedFirst ? unrelated : string.Empty) + """
            BuildsResponse:
              type: object
              properties:
                included:
                  type: array
                  items:
                    oneOf:
                      - type: string
                      - type: integer
                a-b:
                  oneOf:
                    - type: string
                    - type: boolean
                a_b:
                  oneOf:
                    - type: string
                    - type: number

        """ + (unrelatedLast ? unrelated : string.Empty);
        var settings = Settings.Default with { StableAnonymousUnionNames = stable };
        var document = yaml.GetOpenApiDocument(settings);
        var properties = document.Components!.Schemas!["BuildsResponse"].Properties!;
        if (!includeCollider)
        {
            properties.Remove("a_b");
        }
        if (reverseProperties)
        {
            var reversed = properties.Reverse().ToArray();
            properties.Clear();
            foreach (var property in reversed)
            {
                properties.Add(property.Key, property.Value);
            }
        }
        var contexts = document.GetSchemas(settings).ToArray();
        CSharpPipeline.ApplyModelNaming(contexts);
        return contexts.Where(context => context.IsAnyOfLikeStructure && !context.IsReference).ToArray();
    }

    [TestMethod]
    public void StableAnonymousUnions_KeepOwnerPathNamesAcrossInsertionAndReordering()
    {
        var baseline = PrepareAnonymousUnions(true).Select(context => context.Id).ToArray();
        baseline.Should().Contain(name => name.StartsWith("BuildsResponseIncludedItem_", StringComparison.Ordinal));
        var before = PrepareAnonymousUnions(true, unrelatedFirst: true).Select(context => context.Id).ToArray();
        var after = PrepareAnonymousUnions(true, unrelatedLast: true).Select(context => context.Id).ToArray();
        before.Should().Contain(baseline);
        after.Should().Contain(baseline);
        before.Should().BeEquivalentTo(after);
        before.Should().OnlyHaveUniqueItems();
        baseline.Count(name => name.StartsWith("BuildsResponseAB_", StringComparison.Ordinal)).Should().Be(2);
        PrepareAnonymousUnions(true).Select(context => context.Id).Should().Equal(baseline);
    }

    [TestMethod]
    public void StableAnonymousUnions_IgnorePropertyOrdinalsAndLaterNormalizedNameCollisions()
    {
        var baseline = PrepareAnonymousUnions(true, includeCollider: false).Select(context => context.Id).ToArray();
        var expanded = PrepareAnonymousUnions(true, reverseProperties: true).Select(context => context.Id).ToArray();
        expanded.Should().Contain(baseline);
        expanded.Should().OnlyHaveUniqueItems();
        expanded.Should().BeEquivalentTo(PrepareAnonymousUnions(true).Select(context => context.Id));
    }

    [TestMethod]
    public void StableAnonymousUnions_PreserveLegacyDefaultAndSettingsRoundTrip()
    {
        PrepareAnonymousUnions(false).Select(context => context.Id).Should().Contain("IncludedItem");
        Settings.Default.StableAnonymousUnionNames.Should().BeFalse();
        var settings = Settings.Default with { StableAnonymousUnionNames = true };
        ((CSharpSettings)settings).ToSettings().StableAnonymousUnionNames.Should().BeTrue();
        ((CSharpSettings)settings).ToSchemaContextSettings().StableAnonymousUnionNames.Should().BeTrue();
        settings.ToSchemaContextSettings().StableAnonymousUnionNames.Should().BeTrue();
    }
}
