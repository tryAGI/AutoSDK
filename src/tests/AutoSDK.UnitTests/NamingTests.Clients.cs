using AutoSDK.Models;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    public void DuplicateNormalizedTagNames_AreDisambiguatedDeterministically()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Tag collision repro
                              version: 1.0.0
                            tags:
                              - name: ttl-settings
                              - name: TTL Settings
                            paths:
                              /api/v1/ttl-settings:
                                get:
                                  tags:
                                    - ttl-settings
                                  operationId: GetApiTtlSettings
                                  responses:
                                    '200':
                                      description: OK
                              /workspaces/current/ttl-settings:
                                get:
                                  tags:
                                    - TTL Settings
                                  operationId: GetWorkspaceTtlSettings
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var rootClient = data.Clients.Single(x => x.Id == "MainConstructor");

        data.Tags.Should().Contain(x => x.Name == "TTL Settings" && x.SafeName == "TtlSettings");
        data.Tags.Should().Contain(x => x.Name == "ttl-settings" && x.SafeName == "TtlSettings2");

        rootClient.Clients.Select(x => x.Name).Should().OnlyHaveUniqueItems();
        data.Methods.Select(x => x.ClassName).Should().OnlyHaveUniqueItems();

        data.Methods.Should().Contain(x => x.Tag.Name == "TTL Settings" && x.ClassName == "TtlSettingsClient");
        data.Methods.Should().Contain(x => x.Tag.Name == "ttl-settings" && x.ClassName == "TtlSettings2Client");
    }
}
