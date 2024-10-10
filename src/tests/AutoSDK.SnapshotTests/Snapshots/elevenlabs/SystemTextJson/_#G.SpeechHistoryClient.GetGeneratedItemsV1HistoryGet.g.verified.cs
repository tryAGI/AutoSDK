//HintName: G.SpeechHistoryClient.GetGeneratedItemsV1HistoryGet.g.cs

#nullable enable

namespace G
{
    public partial class SpeechHistoryClient
    {
        partial void PrepareGetGeneratedItemsV1HistoryGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? startAfterHistoryItemId,
            ref string? voiceId,
            ref string? xiApiKey);
        partial void PrepareGetGeneratedItemsV1HistoryGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? startAfterHistoryItemId,
            string? voiceId,
            string? xiApiKey);
        partial void ProcessGetGeneratedItemsV1HistoryGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetGeneratedItemsV1HistoryGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Generated Items<br/>
        /// Returns metadata about all your generated audio.
        /// </summary>
        /// <param name="pageSize">
        /// How many history items to return at maximum. Can not exceed 1000, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startAfterHistoryItemId">
        /// After which ID to start fetching, use this parameter to paginate across a large collection of history items. In case this parameter is not provided history items will be fetched starting from the most recently created one ordered descending by their creation date.
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be filtered for, you can use GET https://api.elevenlabs.io/v1/voices to receive a list of voices and their IDs.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetSpeechHistoryResponseModel> GetGeneratedItemsV1HistoryGetAsync(
            int? pageSize = 100,
            string? startAfterHistoryItemId = default,
            string? voiceId = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetGeneratedItemsV1HistoryGetArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                startAfterHistoryItemId: ref startAfterHistoryItemId,
                voiceId: ref voiceId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/history",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("start_after_history_item_id", startAfterHistoryItemId) 
                .AddOptionalParameter("voice_id", voiceId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetGeneratedItemsV1HistoryGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                startAfterHistoryItemId: startAfterHistoryItemId,
                voiceId: voiceId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetGeneratedItemsV1HistoryGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetGeneratedItemsV1HistoryGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetSpeechHistoryResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}