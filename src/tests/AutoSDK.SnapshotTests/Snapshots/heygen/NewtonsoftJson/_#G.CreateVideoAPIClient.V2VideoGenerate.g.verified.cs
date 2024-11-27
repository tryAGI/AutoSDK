//HintName: G.CreateVideoAPIClient.V2VideoGenerate.g.cs

#nullable enable

namespace G
{
    public partial class CreateVideoAPIClient
    {
        partial void PrepareV2VideoGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.V2VideoGenerateRequest request);
        partial void PrepareV2VideoGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.V2VideoGenerateRequest request);
        partial void ProcessV2VideoGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            global::G.V2VideoGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV2VideoGenerateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/video/generate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareV2VideoGenerateRequest(
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
            ProcessV2VideoGenerateResponse(
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
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <param name="callbackId"></param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="videoInputs">
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            object? aspectRatio = default,
            object? callbackId = default,
            global::G.V2VideoGenerateRequestDimension? dimension = default,
            bool? test = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? videoInputs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.V2VideoGenerateRequest
            {
                AspectRatio = aspectRatio,
                CallbackId = callbackId,
                Dimension = dimension,
                Test = test,
                Title = title,
                VideoInputs = videoInputs,
            };

            await V2VideoGenerateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}