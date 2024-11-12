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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoTranslateAsync(
            global::G.V2VideoTranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV2VideoTranslateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/video_translate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV2VideoTranslateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV2VideoTranslateResponse(
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
            var __request = new global::G.V2VideoTranslateRequest
            {
                OutputLanguage = outputLanguage,
                SpeakerNum = speakerNum,
                Title = title,
                TranslateAudioOnly = translateAudioOnly,
                VideoUrl = videoUrl,
            };

            await V2VideoTranslateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}