//HintName: G.PublicClient.ReadSharedExamples.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref global::G.AnyOf<global::System.DateTime?, string>? asOf,
            ref string? metadata,
            ref int? offset,
            ref int? limit,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            ref string? filter);
        partial void PrepareReadSharedExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::G.AnyOf<global::System.DateTime?, string>? asOf,
            string? metadata,
            int? offset,
            int? limit,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            string? filter);
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
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadSharedExamplesArguments(
                httpClient: HttpClient,
                shareToken: ref shareToken,
                id: id,
                asOf: ref asOf,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                select: select,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/examples",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("as_of", asOf?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadSharedExamplesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                shareToken: shareToken,
                id: id,
                asOf: asOf,
                metadata: metadata,
                offset: offset,
                limit: limit,
                select: select,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadSharedExamplesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadSharedExamplesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Example>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}