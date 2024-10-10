//HintName: G.PronunciationDictionaryClient.GetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGet.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dictionaryId,
            ref string versionId,
            ref string? xiApiKey);
        partial void PrepareGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dictionaryId,
            string versionId,
            string? xiApiKey);
        partial void ProcessGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The id of the version of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetAsync(
            string dictionaryId,
            string versionId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetArguments(
                httpClient: _httpClient,
                dictionaryId: ref dictionaryId,
                versionId: ref versionId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/pronunciation-dictionaries/{dictionaryId}/{versionId}/download",
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
            PrepareGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                dictionaryId: dictionaryId,
                versionId: versionId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetPLSFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.HTTPValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}