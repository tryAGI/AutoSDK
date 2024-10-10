//HintName: G.PronunciationDictionaryClient.GetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGet.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pronunciationDictionaryId,
            ref string? xiApiKey);
        partial void PrepareGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pronunciationDictionaryId,
            string? xiApiKey);
        partial void ProcessGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Metadata For A Pronunciation Dictionary<br/>
        /// Get metadata for a pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionaryMetadataResponseModel> GetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetAsync(
            string pronunciationDictionaryId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetArguments(
                httpClient: _httpClient,
                pronunciationDictionaryId: ref pronunciationDictionaryId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/pronunciation-dictionaries/{pronunciationDictionaryId}/",
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
            PrepareGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetMetadataForAPronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdGetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetPronunciationDictionaryMetadataResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}