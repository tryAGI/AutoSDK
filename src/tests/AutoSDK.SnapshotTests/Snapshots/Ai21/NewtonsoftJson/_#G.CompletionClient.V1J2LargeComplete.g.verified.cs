//HintName: G.CompletionClient.V1J2LargeComplete.g.cs

#nullable enable

namespace G
{
    public partial class CompletionClient
    {
        partial void PrepareV1J2LargeCompleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? model,
            global::G.CompletionBody request);
        partial void PrepareV1J2LargeCompleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? model,
            global::G.CompletionBody request);
        partial void ProcessV1J2LargeCompleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1J2LargeCompleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// j2-large complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-large
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1J2LargeCompleteResponse> V1J2LargeCompleteAsync(
            global::G.CompletionBody request,
            string? model = "j2-large",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1J2LargeCompleteArguments(
                httpClient: _httpClient,
                model: ref model,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/j2-large/complete",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("model", model) 
                ; 
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
            PrepareV1J2LargeCompleteRequest(
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
            ProcessV1J2LargeCompleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1J2LargeCompleteResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.V1J2LargeCompleteResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// j2-large complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-large
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
        public async global::System.Threading.Tasks.Task<global::G.V1J2LargeCompleteResponse> V1J2LargeCompleteAsync(
            string prompt,
            string? model = "j2-large",
            int? numResults = 1,
            int? maxTokens = 16,
            int? minTokens = 0,
            double? temperature = 1,
            double? topP = 1,
            double? minP = 0,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topKReturn = 0,
            global::G.CompletionBodyLogitBias? logitBias = default,
            global::G.AllOf<global::G.Penalty>? frequencyPenalty = default,
            global::G.AllOf<global::G.Penalty>? presencePenalty = default,
            global::G.AllOf<global::G.Penalty>? countPenalty = default,
            int? epoch = default,
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

            return await V1J2LargeCompleteAsync(
                model: model,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}