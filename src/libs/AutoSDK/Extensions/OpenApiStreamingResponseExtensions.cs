using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

/// <summary>
/// Finds 2XX responses that declare a streaming media type while describing no payload.
/// </summary>
/// <remarks>
/// A streaming media type on a success response is the only thing that makes AutoSDK generate an
/// <c>IAsyncEnumerable</c> method, and enumerating events means deserializing each one into a type.
/// A response that declares <c>text/event-stream</c> and carries no schema gives it nothing to
/// enumerate, so the generator demotes that response to an ordinary one rather than failing - see
/// <c>CSharpEndPointFactory</c>. The demotion is silent in the generated code, which is why it is
/// reported: the operation really is streamable and really has lost its streaming method, and
/// nothing but the spec can give it back.
///
/// Weaviate's <c>POST /mcp</c> is the case this was written for, where the 200 is described only as
/// "JSON-RPC response or SSE stream".
/// </remarks>
public static class OpenApiStreamingResponseExtensions
{
    /// <summary>
    /// Lists the operations whose 2XX declares a streaming media type with no schema behind it.
    /// </summary>
    public static IReadOnlyList<(string Operation, string MediaType)> FindStreamingResponsesWithoutSchema(
        this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        var findings = new List<(string Operation, string MediaType)>();
        foreach (var path in document.Paths ?? [])
        {
            if (path.Value?.Operations is not { } operations)
            {
                continue;
            }

            foreach (var operation in operations)
            {
                if (operation.Value?.Responses is not { } responses)
                {
                    continue;
                }

                foreach (var response in responses)
                {
                    // `default` is an error channel here, not a success payload.
                    if (!response.Key.StartsWith("2", StringComparison.Ordinal))
                    {
                        continue;
                    }

                    if (response.Value?.Content is not { } content2XX)
                    {
                        continue;
                    }

                    foreach (var content in content2XX)
                    {
                        if (!content.Key.IsServerSentEventsMimeType() &&
                            !content.Key.IsSequentialJsonMimeType() &&
                            !content.Key.IsAwsEventStreamMimeType())
                        {
                            continue;
                        }

                        // A `$ref` is a schema; only an absent one is the gap.
                        if (content.Value?.Schema is not null)
                        {
                            continue;
                        }

                        var name = string.IsNullOrWhiteSpace(operation.Value?.OperationId)
                            ? $"{operation.Key.ToString().ToUpperInvariant()} {path.Key}"
                            : operation.Value!.OperationId!;
                        findings.Add((name, content.Key));
                    }
                }
            }
        }

        return findings;
    }
}
