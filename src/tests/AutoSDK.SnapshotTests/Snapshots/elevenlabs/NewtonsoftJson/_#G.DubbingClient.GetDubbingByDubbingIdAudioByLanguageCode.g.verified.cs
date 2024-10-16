//HintName: G.DubbingClient.GetDubbingByDubbingIdAudioByLanguageCode.g.cs

#nullable enable

namespace G
{
    public partial class DubbingClient
    {
        partial void PrepareGetDubbingByDubbingIdAudioByLanguageCodeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dubbingId,
            ref string languageCode,
            ref string? xiApiKey);
        partial void PrepareGetDubbingByDubbingIdAudioByLanguageCodeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dubbingId,
            string languageCode,
            string? xiApiKey);
        partial void ProcessGetDubbingByDubbingIdAudioByLanguageCodeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDubbingByDubbingIdAudioByLanguageCodeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Get Dubbed File<br/>
        /// Returns dubbed file as a streamed file. Videos will be returned in MP4 format and audio only dubs will be returned in MP3.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ID of the language.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> GetDubbingByDubbingIdAudioByLanguageCodeAsync(
            string dubbingId,
            string languageCode,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDubbingByDubbingIdAudioByLanguageCodeArguments(
                httpClient: _httpClient,
                dubbingId: ref dubbingId,
                languageCode: ref languageCode,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/dubbing/{dubbingId}/audio/{languageCode}",
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
            PrepareGetDubbingByDubbingIdAudioByLanguageCodeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                dubbingId: dubbingId,
                languageCode: languageCode,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDubbingByDubbingIdAudioByLanguageCodeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

            ProcessGetDubbingByDubbingIdAudioByLanguageCodeResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);


            response.EnsureSuccessStatusCode();

            return __content;
        }
    }
}