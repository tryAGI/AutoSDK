//HintName: G.PublicClient.QuerySharedRuns.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareQuerySharedRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::G.QueryParamsForPublicRunSchema request);
        partial void PrepareQuerySharedRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::G.QueryParamsForPublicRunSchema request);
        partial void ProcessQuerySharedRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQuerySharedRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query Shared Runs<br/>
        /// Get run by ids or the shared run if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPublicRunsResponse> QuerySharedRunsAsync(
            string shareToken,
            global::G.QueryParamsForPublicRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareQuerySharedRunsArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/runs/query", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareQuerySharedRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessQuerySharedRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessQuerySharedRunsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListPublicRunsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Query Shared Runs<br/>
        /// Get run by ids or the shared run if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPublicRunsResponse> QuerySharedRunsAsync(
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, object?>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.QueryParamsForPublicRunSchema
            {
                Id = id,
            };

            return await QuerySharedRunsAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}