//HintName: G.SpeechHistoryClient.GetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGet.g.cs

#nullable enable

namespace G
{
    public partial class SpeechHistoryClient
    {
        partial void PrepareGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string historyItemId,
            ref string? xiApiKey);
        partial void PrepareGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string historyItemId,
            string? xiApiKey);
        partial void ProcessGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Audio From History Item<br/>
        /// Returns the audio of an history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetAsync(
            string historyItemId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetArguments(
                httpClient: _httpClient,
                historyItemId: ref historyItemId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/history/{historyItemId}/audio",
                baseUri: _httpClient.BaseAddress); 
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
            PrepareGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                historyItemId: historyItemId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetAudioFromHistoryItemV1HistoryHistoryItemIdAudioGetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.HTTPValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}