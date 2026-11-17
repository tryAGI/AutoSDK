using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

/// <summary>
/// A 2XX that declares a streaming media type and no payload.
/// </summary>
/// <remarks>
/// A streaming media type is the only thing that makes AutoSDK emit an <c>IAsyncEnumerable</c>
/// method, and enumerating events means deserializing each one into a type. Weaviate's
/// <c>POST /mcp</c> lists <c>text/event-stream</c> among its <c>produces</c> while describing its
/// 200 only as "JSON-RPC response or SSE stream", which left the generator with a stream it could
/// not write a return type for - it threw out of a <c>Parallel.For</c> worker and failed the whole
/// run over one operation.
/// </remarks>
[TestClass]
public class StreamingWithoutSchemaTests
{
    private static OpenApiDocument DocumentWith(
        string mediaType,
        IOpenApiSchema? schema,
        string statusCode = "200",
        string? operationId = "mcp.post")
    {
        return new OpenApiDocument
        {
            Paths = new OpenApiPaths
            {
                ["/mcp"] = new OpenApiPathItem
                {
                    Operations = new Dictionary<HttpMethod, OpenApiOperation>
                    {
                        [HttpMethod.Post] = new()
                        {
                            OperationId = operationId,
                            Responses = new OpenApiResponses
                            {
                                [statusCode] = new OpenApiResponse
                                {
                                    Content = new Dictionary<string, IOpenApiMediaType>
                                    {
                                        [mediaType] = new OpenApiMediaType { Schema = schema },
                                    },
                                },
                            },
                        },
                    },
                },
            },
        };
    }

    [TestMethod]
    public void FindsTheServerSentEventsResponseWithNoSchema()
    {
        var findings = DocumentWith("text/event-stream", schema: null)
            .FindStreamingResponsesWithoutSchema();

        findings.Should().HaveCount(1);
        findings[0].Operation.Should().Be("mcp.post");
        findings[0].MediaType.Should().Be("text/event-stream");
    }

    [TestMethod]
    public void FindsNdjsonToo()
    {
        DocumentWith("application/x-ndjson", schema: null)
            .FindStreamingResponsesWithoutSchema()
            .Should().HaveCount(1);
    }

    [TestMethod]
    public void IgnoresAStreamingResponseThatHasASchema()
    {
        DocumentWith("text/event-stream", new OpenApiSchema { Type = JsonSchemaType.Object })
            .FindStreamingResponsesWithoutSchema()
            .Should().BeEmpty();
    }

    [TestMethod]
    public void IgnoresASchemalessResponseThatIsNotStreaming()
    {
        // A plain JSON 200 with no schema is an ordinary no-content response, not a lost stream.
        DocumentWith("application/json", schema: null)
            .FindStreamingResponsesWithoutSchema()
            .Should().BeEmpty();
    }

    [TestMethod]
    public void IgnoresErrorResponses()
    {
        // Only a success response can become a streaming method.
        DocumentWith("text/event-stream", schema: null, statusCode: "500")
            .FindStreamingResponsesWithoutSchema()
            .Should().BeEmpty();
    }

    [TestMethod]
    public void NamesTheOperationByMethodAndPathWhenItHasNoOperationId()
    {
        var findings = DocumentWith("text/event-stream", schema: null, operationId: null)
            .FindStreamingResponsesWithoutSchema();

        findings.Should().HaveCount(1);
        findings[0].Operation.Should().Be("POST /mcp");
    }

    [TestMethod]
    public void AnEmptyDocumentFindsNothing()
    {
        new OpenApiDocument().FindStreamingResponsesWithoutSchema().Should().BeEmpty();
    }
}
