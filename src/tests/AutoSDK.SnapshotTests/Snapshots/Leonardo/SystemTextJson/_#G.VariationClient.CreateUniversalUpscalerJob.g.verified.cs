//HintName: G.VariationClient.CreateUniversalUpscalerJob.g.cs

#nullable enable

namespace G
{
    public partial class VariationClient
    {
        partial void PrepareCreateUniversalUpscalerJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateUniversalUpscalerJobRequest request);
        partial void PrepareCreateUniversalUpscalerJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateUniversalUpscalerJobRequest request);
        partial void ProcessCreateUniversalUpscalerJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateUniversalUpscalerJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            global::G.CreateUniversalUpscalerJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateUniversalUpscalerJobArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/variations/universal-upscaler",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateUniversalUpscalerJobRequest(
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
            ProcessCreateUniversalUpscalerJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateUniversalUpscalerJobResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateUniversalUpscalerJobResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="initImageId">
        /// The ID of the init image uploaded
        /// </param>
        /// <param name="generatedImageId">
        /// The ID of the generated image
        /// </param>
        /// <param name="variationId">
        /// The ID of the variation image
        /// </param>
        /// <param name="upscalerStyle">
        /// The style to upscale images using universal upscaler with.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="creativityStrength">
        /// The creativity strength of the universal upscaler, must be integer between 1 and 10<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="upscaleMultiplier">
        /// The upscale multiplier of the universal upscaler, must be number between 1.00 and 2.00<br/>
        /// Default Value: 1.5
        /// </param>
        /// <param name="prompt">
        /// The prompt for the universal upscaler
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            string? initImageId = default,
            string? generatedImageId = default,
            string? variationId = default,
            global::G.UniversalUpscalerStyle? upscalerStyle = global::G.UniversalUpscalerStyle.GENERAL,
            int? creativityStrength = 5,
            double? upscaleMultiplier = 1.5,
            string? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateUniversalUpscalerJobRequest
            {
                InitImageId = initImageId,
                GeneratedImageId = generatedImageId,
                VariationId = variationId,
                UpscalerStyle = upscalerStyle,
                CreativityStrength = creativityStrength,
                UpscaleMultiplier = upscaleMultiplier,
                Prompt = prompt,
            };

            return await CreateUniversalUpscalerJobAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}