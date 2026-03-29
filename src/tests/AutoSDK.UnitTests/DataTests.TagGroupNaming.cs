namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void ExtensionGroupTagCollision_DropsEmptyOriginalTagBeforeResolvingClientNames(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: TagGroupCollision
                              version: 1.0.0
                            tags:
                              - name: Corpora
                            paths:
                              /corpora:
                                get:
                                  operationId: listCorpora
                                  tags:
                                    - Corpora
                                  x-fern-sdk-group-name: corpora
                                  responses:
                                    '200':
                                      description: ok
                            """;

        var data = PrepareOpenApi(useLegacyPrepare, yaml, DefaultSettings);

        data.Tags.Select(x => x.SafeName).Should().Equal("Corpora");
        data.Methods.Should().ContainSingle();
        data.Methods[0].Tag.Name.Should().Be("corpora");
        data.Methods[0].Tag.SafeName.Should().Be("Corpora");
        data.Clients.Select(x => x.ClassName).Should().Contain("CorporaClient");
        data.Clients.Select(x => x.ClassName).Should().NotContain("Corpora2Client");
    }
}
