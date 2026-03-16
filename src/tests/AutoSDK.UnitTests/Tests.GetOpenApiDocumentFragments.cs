using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class GetOpenApiDocumentFragmentTests
{
    [TestMethod]
    public void PromotesHeaderlessYamlFragment()
    {
        var yaml = """
tags:
  - name: ping
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: ok
""";

        var document = yaml.GetOpenApiDocument(Settings.Default);

        Assert.IsNotNull(document.Info);
        Assert.AreEqual("AutoSDK Generated Fragment", document.Info.Title);
        Assert.AreEqual(1, document.Paths.Count);
        Assert.IsTrue(document.Paths.ContainsKey("/ping"));
    }

    [TestMethod]
    public void PromotesHeaderlessJsonFragment()
    {
        var json = """
{
  "paths": {
    "/ping": {
      "get": {
        "operationId": "ping",
        "responses": {
          "200": {
            "description": "ok"
          }
        }
      }
    }
  }
}
""";

        var document = json.GetOpenApiDocument(Settings.Default);

        Assert.IsNotNull(document.Info);
        Assert.AreEqual("AutoSDK Generated Fragment", document.Info.Title);
        Assert.AreEqual(1, document.Paths.Count);
        Assert.IsTrue(document.Paths.ContainsKey("/ping"));
    }
}
