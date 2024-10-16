//HintName: G.DubbingClient.GetDubbingByDubbingIdTranscriptByLanguageCode.g.cs

#nullable enable

namespace G
{
    public partial class DubbingClient
    {
        partial void PrepareGetDubbingByDubbingIdTranscriptByLanguageCodeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dubbingId,
            ref string languageCode,
            ref global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType,
            ref string? xiApiKey);
        partial void PrepareGetDubbingByDubbingIdTranscriptByLanguageCodeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dubbingId,
            string languageCode,
            global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType,
            string? xiApiKey);
        partial void ProcessGetDubbingByDubbingIdTranscriptByLanguageCodeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDubbingByDubbingIdTranscriptByLanguageCodeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Transcript For Dub<br/>
        /// Returns transcript for the dub as an SRT file.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ID of the language.
        /// </param>
        /// <param name="formatType">
        /// Format to use for the subtitle file, either 'srt' or 'webvtt'
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> GetDubbingByDubbingIdTranscriptByLanguageCodeAsync(
            string dubbingId,
            string languageCode,
            global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDubbingByDubbingIdTranscriptByLanguageCodeArguments(
                httpClient: _httpClient,
                dubbingId: ref dubbingId,
                languageCode: ref languageCode,
                formatType: ref formatType,
                xiApiKey: ref xiApiKey);

            var formatTypeValue = formatType switch
            {
                global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Srt => "srt",
                global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Webvtt => "webvtt",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/v1/dubbing/{dubbingId}/transcript/{languageCode}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("format_type", formatTypeValue?.ToString()) 
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
            PrepareGetDubbingByDubbingIdTranscriptByLanguageCodeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                dubbingId: dubbingId,
                languageCode: languageCode,
                formatType: formatType,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDubbingByDubbingIdTranscriptByLanguageCodeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDubbingByDubbingIdTranscriptByLanguageCodeResponseContent(
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

            return __content;
        }
    }
}