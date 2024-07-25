//HintName: G.FeedbackConfigsClient.ListFeedbackConfigsEndpoint.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackConfigsClient
    {
        partial void PrepareListFeedbackConfigsEndpointArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object> key);
        partial void PrepareListFeedbackConfigsEndpointRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object> key);
        partial void ProcessListFeedbackConfigsEndpointResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFeedbackConfigsEndpointResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackConfigSchema>> ListFeedbackConfigsEndpointAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object> key,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListFeedbackConfigsEndpointArguments(
                httpClient: _httpClient,
                key: ref key);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback-configs?key={key}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListFeedbackConfigsEndpointRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                key: key);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListFeedbackConfigsEndpointResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListFeedbackConfigsEndpointResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.FeedbackConfigSchema>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}