//HintName: G.PublicClient.ReadSharedExamples.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<global::System.DateTime?, string>? asOf,
            ref global::System.AnyOf<string, object>? metadata,
            ref int offset,
            ref int limit,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            ref global::System.AnyOf<string, object>? filter);
        partial void PrepareReadSharedExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::System.DateTime?, string>? asOf,
            global::System.AnyOf<string, object>? metadata,
            int offset,
            int limit,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            global::System.AnyOf<string, object>? filter);
        partial void ProcessReadSharedExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Examples<br/>
        /// Get example by ids or the shared example if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> ReadSharedExamplesAsync(
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id = default,
            global::System.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::System.AnyOf<string, object>? metadata = default,
            int offset = 0,
            int limit = 100,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select = default,
            global::System.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedExamplesArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                id: ref id,
                asOf: ref asOf,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                select: select,
                filter: ref filter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/examples?id={id}&as_of={asOf}&metadata={metadata}&offset={offset}&limit={limit}&{string.Join("&", select?.Select(static x => $"select={x}") ?? global::System.Array.Empty<string>())}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedExamplesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                id: id,
                asOf: asOf,
                metadata: metadata,
                offset: offset,
                limit: limit,
                select: select,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedExamplesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedExamplesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Example>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}