//HintName: G.Api.GenerateContent.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGenerateContentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            global::G.GenerateContentRequest request);
        partial void PrepareGenerateContentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            global::G.GenerateContentRequest request);
        partial void ProcessGenerateContentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateContentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: gemini-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateContentResponse> GenerateContentAsync(
            string modelId,
            global::G.GenerateContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGenerateContentArguments(
                httpClient: _httpClient,
                modelId: ref modelId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelId}:generateContent",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGenerateContentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelId: modelId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGenerateContentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGenerateContentResponseContent(
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

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GenerateContentResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: gemini-pro
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateContentResponse> GenerateContentAsync(
            string modelId,
            global::G.GenerationConfig? generationConfig = default,
            global::System.Collections.Generic.IList<global::G.Content>? contents = default,
            global::System.Collections.Generic.IList<global::G.SafetySetting>? safetySettings = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GenerateContentRequest
            {
                GenerationConfig = generationConfig,
                Contents = contents,
                SafetySettings = safetySettings,
            };

            return await GenerateContentAsync(
                modelId: modelId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}