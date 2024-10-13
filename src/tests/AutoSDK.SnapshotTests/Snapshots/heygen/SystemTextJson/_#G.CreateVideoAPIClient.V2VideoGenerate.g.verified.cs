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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            global::G.V2VideoGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV2VideoGenerateArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/video/generate",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV2VideoGenerateRequest(
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
            ProcessV2VideoGenerateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
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
            var request = new global::G.V2VideoGenerateRequest
            {
                AspectRatio = aspectRatio,
                CallbackId = callbackId,
                Dimension = dimension,
                Test = test,
                Title = title,
                VideoInputs = videoInputs,
            };

            await V2VideoGenerateAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}