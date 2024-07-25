//HintName: G.TracerSessionsClient.UpdateFilterView.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareUpdateFilterViewArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            ref string viewId,
            global::G.FilterViewUpdate request);
        partial void PrepareUpdateFilterViewRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            string viewId,
            global::G.FilterViewUpdate request);
        partial void ProcessUpdateFilterViewResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateFilterViewResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FilterView> UpdateFilterViewAsync(
            string sessionId,
            string viewId,
            global::G.FilterViewUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateFilterViewArguments(
                httpClient: _httpClient,
                sessionId: ref sessionId,
                viewId: ref viewId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions/{sessionId}/views/{viewId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateFilterViewRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sessionId: sessionId,
                viewId: viewId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateFilterViewResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateFilterViewResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FilterView?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FilterView> UpdateFilterViewAsync(
            string sessionId,
            string viewId,
            global::System.AnyOf<string?, object?>? filterString = default,
            global::System.AnyOf<string?, object?>? displayName = default,
            global::System.AnyOf<string?, object?>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FilterViewUpdate
            {
                FilterString = filterString,
                DisplayName = displayName,
                Description = description,
            };

            return await UpdateFilterViewAsync(
                sessionId: sessionId,
                viewId: viewId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}