//HintName: G.CompletionClient.V1J2UltraComplete2.g.cs

#nullable enable

namespace G
{
    public partial class CompletionClient
    {
        partial void PrepareV1J2UltraComplete2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string customModelName,
            ref string? customModelType,
            global::G.CompletionBody request);
        partial void PrepareV1J2UltraComplete2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string customModelName,
            string? customModelType,
            global::G.CompletionBody request);
        partial void ProcessV1J2UltraComplete2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1J2UltraComplete2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Custom j2-ultra complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1J2UltraCompleteResponse2> V1J2UltraComplete2Async(
            string customModelName,
            string? customModelType,
            global::G.CompletionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1J2UltraComplete2Arguments(
                httpClient: _httpClient,
                customModelName: ref customModelName,
                customModelType: ref customModelType,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/j2-ultra/{customModelName}/complete?custom_model_type={customModelType}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1J2UltraComplete2Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                customModelName: customModelName,
                customModelType: customModelType,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1J2UltraComplete2Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1J2UltraComplete2ResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.V1J2UltraCompleteResponse2?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Custom j2-ultra complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-ultra
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
        public async global::System.Threading.Tasks.Task<global::G.V1J2UltraCompleteResponse2> V1J2UltraComplete2Async(
            string customModelName,
            string prompt,
            string? customModelType = "j2-ultra",
            int numResults = 1,
            int maxTokens = 16,
            int minTokens = 0,
            double temperature = 1,
            double topP = 1,
            double minP = 0,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int topKReturn = 0,
            global::G.CompletionBodyLogitBias? logitBias = default,
            global::System.AllOf<global::G.Penalty>? frequencyPenalty = default,
            global::System.AllOf<global::G.Penalty>? presencePenalty = default,
            global::System.AllOf<global::G.Penalty>? countPenalty = default,
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

            return await V1J2UltraComplete2Async(
                customModelName: customModelName,
                customModelType: customModelType,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}