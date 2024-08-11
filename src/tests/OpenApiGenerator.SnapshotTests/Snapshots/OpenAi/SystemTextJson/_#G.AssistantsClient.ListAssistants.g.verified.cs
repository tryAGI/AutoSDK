//HintName: G.AssistantsClient.ListAssistants.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        partial void PrepareListAssistantsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int limit,
            ref global::G.ListAssistantsOrder? order,
            ref string? after,
            ref string? before);
        partial void PrepareListAssistantsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int limit,
            global::G.ListAssistantsOrder? order,
            string? after,
            string? before);
        partial void ProcessListAssistantsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListAssistantsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of assistants.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListAssistantsResponse> ListAssistantsAsync(
            int limit,
            global::G.ListAssistantsOrder? order,
            string? after,
            string? before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListAssistantsArguments(
                httpClient: _httpClient,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/assistants?limit={limit}&order={order}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListAssistantsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                order: order,
                after: after,
                before: before);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListAssistantsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListAssistantsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListAssistantsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}