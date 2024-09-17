//HintName: G.VideoTranslateAPIClient.V2VideoTranslate.g.cs

#nullable enable

namespace G
{
    public partial class VideoTranslateAPIClient
    {
        partial void PrepareV2VideoTranslateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.V2VideoTranslateRequest request);
        partial void PrepareV2VideoTranslateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.V2VideoTranslateRequest request);
        partial void ProcessV2VideoTranslateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// v2/video_translate<br/>
        /// Generated Video: [https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9](https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoTranslateAsync(
            global::G.V2VideoTranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV2VideoTranslateArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v2/video_translate", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV2VideoTranslateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV2VideoTranslateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// v2/video_translate<br/>
        /// Generated Video: [https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9](https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9)
        /// </summary>
        /// <param name="outputLanguage">
        /// Example: English - American Accent
        /// </param>
        /// <param name="speakerNum">
        /// Example: 1
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="translateAudioOnly">
        /// Example: false
        /// </param>
        /// <param name="videoUrl">
        /// Example: https://static.heygen.ai/heygen/asset/originalnew.mp4
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoTranslateAsync(
            string? outputLanguage = default,
            double? speakerNum = default,
            string? title = default,
            bool? translateAudioOnly = default,
            string? videoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.V2VideoTranslateRequest
            {
                OutputLanguage = outputLanguage,
                SpeakerNum = speakerNum,
                Title = title,
                TranslateAudioOnly = translateAudioOnly,
                VideoUrl = videoUrl,
            };

            await V2VideoTranslateAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}