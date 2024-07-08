//HintName: G.AssistantsClient.ListRuns.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        partial void PrepareListRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref int limit,
            ref global::G.ListRunsOrder order,
            ref string after,
            ref string before);
        partial void PrepareListRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            int limit,
            global::G.ListRunsOrder order,
            string after,
            string before);
        partial void ProcessListRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of runs belonging to a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListRunsResponse> ListRunsAsync(
            string threadId,
            int limit,
            global::G.ListRunsOrder order,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRunsArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before);

            var orderValue = order switch
            {
                global::G.ListRunsOrder.Asc => "asc",
                global::G.ListRunsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/threads/{threadId}/runs?limit={limit}&order={orderValue}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
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
            ProcessListRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRunsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListRunsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}