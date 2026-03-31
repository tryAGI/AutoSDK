//HintName: G.Api.Sam3VisualSegmentSam3VisualSegmentPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareSam3VisualSegmentSam3VisualSegmentPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? apiKey,
            bool? countinference,
            ref string? serviceSecret,
            global::G.Sam2SegmentationRequest request);
        partial void PrepareSam3VisualSegmentSam3VisualSegmentPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? apiKey,
            bool? countinference,
            string? serviceSecret,
            global::G.Sam2SegmentationRequest request);
        partial void ProcessSam3VisualSegmentSam3VisualSegmentPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSam3VisualSegmentSam3VisualSegmentPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SAM3 PVS (promptable visual segmentation)<br/>
        /// Run the SAM3 PVS (promptable visual segmentation) to generate segmentations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Sam2SegmentationResponse> Sam3VisualSegmentSam3VisualSegmentPostAsync(

            global::G.Sam2SegmentationRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSam3VisualSegmentSam3VisualSegmentPostArguments(
                httpClient: HttpClient,
                apiKey: ref apiKey,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/sam3/visual_segment",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("api_key", apiKey)
                .AddOptionalParameter("countinference", countinference?.ToString().ToLowerInvariant())
                .AddOptionalParameter("service_secret", serviceSecret) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSam3VisualSegmentSam3VisualSegmentPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                apiKey: apiKey,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSam3VisualSegmentSam3VisualSegmentPostResponse(
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
                ProcessSam3VisualSegmentSam3VisualSegmentPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Sam2SegmentationResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Sam2SegmentationResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// SAM3 PVS (promptable visual segmentation)<br/>
        /// Run the SAM3 PVS (promptable visual segmentation) to generate segmentations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="requestApiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sam2VersionId">
        /// The version ID of SAM to be used for this request. Must be one of hiera_tiny, hiera_small, hiera_large, hiera_b_plus<br/>
        /// Default Value: hiera_large
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="format">
        /// The format of the response. Must be one of 'json', 'rle', or 'binary'. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons. If rle, masks are converted to RLE format.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The image to be segmented.
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </param>
        /// <param name="prompts">
        /// A list of prompts for masks to predict. Each prompt can include a bounding box and / or a set of postive or negative points. Also accepts a flat array of prompts (e.g. 'prompts': [{...}, {...}]) for convenience.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="multimaskOutput">
        /// If true, the model will return three masks. For ambiguous input prompts (such as a single click), this will often produce better masks than a single prediction. If only a single mask is needed, the model's predicted quality score can be used to select the best mask. For non-ambiguous prompts, such as multiple input prompts, multimask_output=False can give better results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="saveLogitsToCache">
        /// If True, saves the low-resolution logits to the cache for potential future use. This can speed up subsequent requests with similar prompts on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loadLogitsFromCache">
        /// If True, attempts to load previously cached low-resolution logits for the given image and prompt set. This can significantly speed up inference when making multiple similar requests on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Sam2SegmentationResponse> Sam3VisualSegmentSam3VisualSegmentPostAsync(
            string id,
            global::G.InferenceRequestImage image,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? sam2VersionId = default,
            string? modelId = default,
            string? format = default,
            string? imageId = default,
            global::G.Sam2PromptSet? prompts = default,
            bool? multimaskOutput = default,
            bool? saveLogitsToCache = default,
            bool? loadLogitsFromCache = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.Sam2SegmentationRequest
            {
                Id = id,
                ApiKey = requestApiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                Sam2VersionId = sam2VersionId,
                ModelId = modelId,
                Format = format,
                Image = image,
                ImageId = imageId,
                Prompts = prompts,
                MultimaskOutput = multimaskOutput,
                SaveLogitsToCache = saveLogitsToCache,
                LoadLogitsFromCache = loadLogitsFromCache,
            };

            return await Sam3VisualSegmentSam3VisualSegmentPostAsync(
                apiKey: apiKey,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}