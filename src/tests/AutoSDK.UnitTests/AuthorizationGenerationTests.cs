using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class AuthorizationGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
    };

    [TestMethod]
    public void Prepare_DeduplicatesTopLevelAuthorizations_WithSameFriendlyName()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: DuplicateAuth
                              version: 1.0.0
                            security:
                              - bearerA: []
                              - bearerB: []
                            paths:
                              /ping:
                                get:
                                  operationId: ping
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                bearerA:
                                  type: http
                                  scheme: bearer
                                bearerB:
                                  type: http
                                  scheme: bearer
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        data.Authorizations.Should().HaveCount(1);
        data.Authorizations[0].FriendlyName.Should().Be("Bearer");
        data.Authorizations.Select(x => Sources.Authorization(x).Name).Should().OnlyHaveUniqueItems();
    }
}
