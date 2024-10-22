//HintName: G.TemplateAPIClient.V2TemplateGenerate.g.cs

#nullable enable

namespace G
{
    public partial class TemplateAPIClient
    {
        partial void PrepareV2TemplateGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.V2TemplateGenerateRequest request);
        partial void PrepareV2TemplateGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.V2TemplateGenerateRequest request);
        partial void ProcessV2TemplateGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// v2/template/generate<br/>
        /// Generated Video: [https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75](https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/7cba9d29d6db46b88471221fdbc4fb75.gif" alt=""&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2TemplateGenerateAsync(
            global::G.V2TemplateGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV2TemplateGenerateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/template/<id>/generate",
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
            PrepareV2TemplateGenerateRequest(
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
            ProcessV2TemplateGenerateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// v2/template/generate<br/>
        /// Generated Video: [https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75](https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/7cba9d29d6db46b88471221fdbc4fb75.gif" alt=""&gt;
        /// </summary>
        /// <param name="caption">
        /// Example: false
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: false
        /// </param>
        /// <param name="title">
        /// Example: New Video
        /// </param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V2TemplateGenerateAsync(
            bool? caption = default,
            global::G.V2TemplateGenerateRequestDimension? dimension = default,
            bool? test = default,
            string? title = default,
            global::G.V2TemplateGenerateRequestVariables? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.V2TemplateGenerateRequest
            {
                Caption = caption,
                Dimension = dimension,
                Test = test,
                Title = title,
                Variables = variables,
            };

            await V2TemplateGenerateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}