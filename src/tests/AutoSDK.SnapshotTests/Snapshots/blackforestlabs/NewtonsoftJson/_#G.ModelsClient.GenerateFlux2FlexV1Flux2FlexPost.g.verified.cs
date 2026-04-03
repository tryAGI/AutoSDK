//HintName: G.ModelsClient.GenerateFlux2FlexV1Flux2FlexPost.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {
        partial void PrepareGenerateFlux2FlexV1Flux2FlexPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Flux2FlexInputs request);
        partial void PrepareGenerateFlux2FlexV1Flux2FlexPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Flux2FlexInputs request);
        partial void ProcessGenerateFlux2FlexV1Flux2FlexPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateFlux2FlexV1Flux2FlexPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate or edit an image with FLUX.2 [FLEX]<br/>
        /// Submits an image generation or editing task with FLUX.2 [FLEX].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2FlexV1Flux2FlexPostAsync(

            global::G.Flux2FlexInputs request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateFlux2FlexV1Flux2FlexPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/flux-2-flex",
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
            PrepareGenerateFlux2FlexV1Flux2FlexPostRequest(
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
            ProcessGenerateFlux2FlexV1Flux2FlexPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGenerateFlux2FlexV1Flux2FlexPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Generate or edit an image with FLUX.2 [FLEX]<br/>
        /// Submits an image generation or editing task with FLUX.2 [FLEX].
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to use prompt upsampling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="inputImage">
        /// Path to the input image.
        /// </param>
        /// <param name="inputImage2">
        /// Path to the second input image.
        /// </param>
        /// <param name="inputImage3">
        /// Path to the third input image.
        /// </param>
        /// <param name="inputImage4">
        /// Path to the fourth input image.
        /// </param>
        /// <param name="inputImage5">
        /// Path to the fifth input image.
        /// </param>
        /// <param name="inputImage6">
        /// Path to the sixth input image.
        /// </param>
        /// <param name="inputImage7">
        /// Path to the seventh input image.
        /// </param>
        /// <param name="inputImage8">
        /// Path to the eighth input image.
        /// </param>
        /// <param name="inputImageBlobPath">
        /// Blob path to the input image.
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="width">
        /// Width of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="height">
        /// Height of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="guidance">
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 5F<br/>
        /// Example: 5F
        /// </param>
        /// <param name="steps">
        /// Number of steps for image generation. Higher steps lead to more detailed and realistic images.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: jpeg
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2FlexV1Flux2FlexPostAsync(
            string prompt,
            bool? promptUpsampling = default,
            string? inputImage = default,
            string? inputImage2 = default,
            string? inputImage3 = default,
            string? inputImage4 = default,
            string? inputImage5 = default,
            string? inputImage6 = default,
            string? inputImage7 = default,
            string? inputImage8 = default,
            string? inputImageBlobPath = default,
            int? seed = default,
            int? width = default,
            int? height = default,
            double? guidance = default,
            int? steps = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Flux2FlexInputs
            {
                Prompt = prompt,
                PromptUpsampling = promptUpsampling,
                InputImage = inputImage,
                InputImage2 = inputImage2,
                InputImage3 = inputImage3,
                InputImage4 = inputImage4,
                InputImage5 = inputImage5,
                InputImage6 = inputImage6,
                InputImage7 = inputImage7,
                InputImage8 = inputImage8,
                InputImageBlobPath = inputImageBlobPath,
                Seed = seed,
                Width = width,
                Height = height,
                Guidance = guidance,
                Steps = steps,
                SafetyTolerance = safetyTolerance,
                OutputFormat = outputFormat,
                WebhookUrl = webhookUrl,
                WebhookSecret = webhookSecret,
            };

            return await GenerateFlux2FlexV1Flux2FlexPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}