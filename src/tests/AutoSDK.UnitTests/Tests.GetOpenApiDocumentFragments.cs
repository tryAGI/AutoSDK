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

    [TestMethod]
    public void ParsesOpenApi31JsonWithNumericExclusiveBounds()
    {
        var json = """
{
  "openapi": "3.1.0",
  "info": {
    "title": "NumericBounds",
    "version": "1.0.0"
  },
  "paths": {},
  "components": {
    "schemas": {
      "Request": {
        "type": "object",
        "properties": {
          "best_of": {
            "type": "integer",
            "minimum": 0,
            "exclusiveMinimum": 0
          },
          "top_p": {
            "type": "number",
            "exclusiveMinimum": 0,
            "exclusiveMaximum": 1
          }
        }
      }
    }
  }
}
""";

        var document = json.GetOpenApiDocument(Settings.Default);
        var schemas = document.Components?.Schemas;
        Assert.IsNotNull(schemas);
        Assert.IsTrue(schemas.ContainsKey("Request"));
        var properties = schemas["Request"].Properties;
        Assert.IsNotNull(properties);
        Assert.IsTrue(properties.ContainsKey("best_of"));
        Assert.IsTrue(properties.ContainsKey("top_p"));
    }

    [TestMethod]
    public void ParsesOpenApi31YamlWithNumericExclusiveBounds()
    {
        var yaml = """
openapi: 3.1.0
info:
  title: NumericBounds
  version: 1.0.0
paths: {}
components:
  schemas:
    Request:
      type: object
      properties:
        temperature:
          type: number
          exclusiveMinimum: -2
        top_k:
          type: integer
          maximum: 100
          exclusiveMaximum: 64
""";

        var document = yaml.GetOpenApiDocument(Settings.Default);
        var schemas = document.Components?.Schemas;
        Assert.IsNotNull(schemas);
        Assert.IsTrue(schemas.ContainsKey("Request"));
        var properties = schemas["Request"].Properties;
        Assert.IsNotNull(properties);
        Assert.IsTrue(properties.ContainsKey("temperature"));
        Assert.IsTrue(properties.ContainsKey("top_k"));
    }

    [TestMethod]
    public void RejectsGrpcProtoInputWithConsistentMessage()
    {
        var proto = """
syntax = "proto3";

package demo;

service Greeter {
  rpc SayHello (HelloRequest) returns (HelloReply);
}
""";

        Action action = () => _ = proto.GetOpenApiDocument(Settings.Default);

        action
            .Should()
            .Throw<NotSupportedException>()
            .WithMessage("*gRPC .proto inputs are not supported by AutoSDK's OpenAPI/AsyncAPI pipeline*");
    }
}
