//HintName: G.Api.Classify.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareClassifyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.ClassifyRequest request);
        partial void PrepareClassifyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.ClassifyRequest request);
        partial void ProcessClassifyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClassifyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Classify<br/>
        /// This endpoint makes a prediction about which label fits the specified text inputs best. To make a prediction, Classify uses the provided `examples` of text + label pairs as a reference.<br/>
        /// Note: [Fine-tuned models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ClassifyResponse> ClassifyAsync(
            global::G.ClassifyRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareClassifyArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            if (xClientName != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/v1/classify",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClassifyRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClassifyResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClassifyResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClassifyResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Classify<br/>
        /// This endpoint makes a prediction about which label fits the specified text inputs best. To make a prediction, Classify uses the provided `examples` of text + label pairs as a reference.<br/>
        /// Note: [Fine-tuned models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="inputs">
        /// A list of up to 96 texts to be classified. Each one must be a non-empty string.<br/>
        /// There is, however, no consistent, universal limit to the length a particular input can be. We perform classification on the first `x` tokens of each input, and `x` varies depending on which underlying model is powering classification. The maximum token length for each model is listed in the "max tokens" column [here](https://docs.cohere.com/docs/models).<br/>
        /// Note: by default the `truncate` parameter is set to `END`, so tokens exceeding the limit will be automatically dropped. This behavior can be disabled by setting `truncate` to `NONE`, which will result in validation errors for longer texts.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="examples">
        /// An array of examples to provide context to the model. Each example is a text string and its associated label/class. Each unique label requires at least 2 examples associated with it; the maximum number of examples is 2500, and each example has a maximum length of 512 tokens. The values should be structured as `{text: "...",label: "..."}`.<br/>
        /// Note: [Fine-tuned Models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// The identifier of the model. Currently available models are `embed-multilingual-v2.0`, `embed-english-light-v2.0`, and `embed-english-v2.0` (default). Smaller "light" models are faster, while larger models will perform better. [Fine-tuned models](https://docs.cohere.com/docs/fine-tuning) can also be supplied with their full ID.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="preset">
        /// The ID of a custom playground preset. You can create presets in the [playground](https://dashboard.cohere.com/playground/classify?model=large). If you use a preset, all other parameters become optional, and any included parameters will override the preset's parameters.<br/>
        /// Included only in requests<br/>
        /// Example: my-preset-a58sbd
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ClassifyResponse> ClassifyAsync(
            global::System.Collections.Generic.IList<string> inputs,
            global::System.Collections.Generic.IList<global::G.ClassifyExample> examples,
            string model,
            string preset,
            global::G.ClassifyRequestTruncate truncate,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ClassifyRequest
            {
                Inputs = inputs,
                Examples = examples,
                Model = model,
                Preset = preset,
                Truncate = truncate,
            };

            return await ClassifyAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}