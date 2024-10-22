//HintName: G.Api.GenerateText.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGenerateTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            global::G.GenerateTextRequest request);
        partial void PrepareGenerateTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            global::G.GenerateTextRequest request);
        partial void ProcessGenerateTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            global::G.GenerateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateTextArguments(
                httpClient: HttpClient,
                modelId: ref modelId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGenerateTextRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelId: modelId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateTextResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGenerateTextResponseContent(
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

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            string? inputs,
            global::G.GenerateTextRequestParameters? parameters = default,
            global::G.GenerateTextRequestOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.GenerateTextRequest
            {
                Inputs = inputs,
                Parameters = parameters,
                Options = options,
            };

            return await GenerateTextAsync(
                modelId: modelId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}