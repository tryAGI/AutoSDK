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
            ref int? charsPerCaption);
        partial void PrepareGetSubtitlesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string transcriptId,
            global::G.SubtitleFormat subtitleFormat,
            int? charsPerCaption);
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
            int? charsPerCaption = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSubtitlesArguments(
                httpClient: HttpClient,
                transcriptId: ref transcriptId,
                subtitleFormat: ref subtitleFormat,
                charsPerCaption: ref charsPerCaption);

            var subtitleFormatValue = subtitleFormat switch
            {
                global::G.SubtitleFormat.Srt => "srt",
                global::G.SubtitleFormat.Vtt => "vtt",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/v2/transcript/{transcriptId}/{subtitleFormatValue}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("chars_per_caption", charsPerCaption?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetSubtitlesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                transcriptId: transcriptId,
                subtitleFormat: subtitleFormat,
                charsPerCaption: charsPerCaption);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSubtitlesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetSubtitlesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }
    }
}