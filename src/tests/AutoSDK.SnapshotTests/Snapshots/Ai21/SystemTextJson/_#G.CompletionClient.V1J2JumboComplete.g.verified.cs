//HintName: G.CompletionClient.V1J2JumboComplete.g.cs

#nullable enable

namespace G
{
    public partial class CompletionClient
    {
        partial void PrepareV1J2JumboCompleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? model,
            global::G.CompletionBody request);
        partial void PrepareV1J2JumboCompleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? model,
            global::G.CompletionBody request);
        partial void ProcessV1J2JumboCompleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1J2JumboCompleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// j2-jumbo complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-jumbo
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1J2JumboCompleteResponse> V1J2JumboCompleteAsync(
            global::G.CompletionBody request,
            string? model = "j2-jumbo",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1J2JumboCompleteArguments(
                httpClient: _httpClient,
                model: ref model,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/j2-jumbo/complete?model={model}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1J2JumboCompleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                model: model,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1J2JumboCompleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1J2JumboCompleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.V1J2JumboCompleteResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// j2-jumbo complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-jumbo
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 16
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="minP">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="epoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1J2JumboCompleteResponse> V1J2JumboCompleteAsync(
            string prompt,
            string? model = "j2-jumbo",
            int numResults = 1,
            int maxTokens = 16,
            int minTokens = 0,
            double temperature = 1,
            double topP = 1,
            double minP = 0,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int topKReturn = 0,
            global::G.CompletionBodyLogitBias? logitBias = default,
            global::G.AllOf<global::G.Penalty>? frequencyPenalty = default,
            global::G.AllOf<global::G.Penalty>? presencePenalty = default,
            global::G.AllOf<global::G.Penalty>? countPenalty = default,
            int epoch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CompletionBody
            {
                Prompt = prompt,
                NumResults = numResults,
                MaxTokens = maxTokens,
                MinTokens = minTokens,
                Temperature = temperature,
                TopP = topP,
                MinP = minP,
                StopSequences = stopSequences,
                TopKReturn = topKReturn,
                LogitBias = logitBias,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                CountPenalty = countPenalty,
                Epoch = epoch,
            };

            return await V1J2JumboCompleteAsync(
                model: model,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}