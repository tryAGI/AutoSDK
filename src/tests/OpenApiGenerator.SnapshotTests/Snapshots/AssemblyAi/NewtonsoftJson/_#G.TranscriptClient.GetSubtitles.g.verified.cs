//HintName: G.TranscriptClient.GetSubtitles.g.cs

#nullable enable

namespace G
{
    public partial class TranscriptClient
    {
        partial void PrepareGetSubtitlesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string transcriptId,
            ref global::G.SubtitleFormat subtitleFormat,
            ref int charsPerCaption);
        partial void PrepareGetSubtitlesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string transcriptId,
            global::G.SubtitleFormat subtitleFormat,
            int charsPerCaption);
        partial void ProcessGetSubtitlesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSubtitlesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get subtitles for transcript<br/>
        /// Export your transcript in SRT or VTT format to use with a video player for subtitles and closed captions.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="subtitleFormat">
        /// Format of the subtitles
        /// </param>
        /// <param name="charsPerCaption"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> GetSubtitlesAsync(
            string transcriptId,
            global::G.SubtitleFormat subtitleFormat,
            int charsPerCaption = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSubtitlesArguments(
                httpClient: _httpClient,
                transcriptId: ref transcriptId,
                subtitleFormat: ref subtitleFormat,
                charsPerCaption: ref charsPerCaption);

            var subtitleFormatValue = subtitleFormat switch
            {
                global::G.SubtitleFormat.Srt => "srt",
                global::G.SubtitleFormat.Vtt => "vtt",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v2/transcript/{transcriptId}/{subtitleFormatValue}?chars_per_caption={charsPerCaption}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSubtitlesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                transcriptId: transcriptId,
                subtitleFormat: subtitleFormat,
                charsPerCaption: charsPerCaption);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSubtitlesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSubtitlesResponseContent(
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