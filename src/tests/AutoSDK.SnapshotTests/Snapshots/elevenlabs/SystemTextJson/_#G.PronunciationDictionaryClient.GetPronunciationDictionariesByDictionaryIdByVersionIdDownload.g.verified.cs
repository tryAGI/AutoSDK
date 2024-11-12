//HintName: G.PronunciationDictionaryClient.GetPronunciationDictionariesByDictionaryIdByVersionIdDownload.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dictionaryId,
            ref string versionId,
            ref string? xiApiKey);
        partial void PrepareGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dictionaryId,
            string versionId,
            string? xiApiKey);
        partial void ProcessGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadAsync(
            string dictionaryId,
            string versionId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadArguments(
                httpClient: HttpClient,
                dictionaryId: ref dictionaryId,
                versionId: ref versionId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/pronunciation-dictionaries/{dictionaryId}/{versionId}/download",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dictionaryId: dictionaryId,
                versionId: versionId,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetPronunciationDictionariesByDictionaryIdByVersionIdDownloadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}