//HintName: G.Api.SamSegmentImageSamSegmentImagePost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareSamSegmentImageSamSegmentImagePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? apiKey,
            bool? countinference,
            ref string? serviceSecret,
            global::G.SamSegmentationRequest request);
        partial void PrepareSamSegmentImageSamSegmentImagePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? apiKey,
            bool? countinference,
            string? serviceSecret,
            global::G.SamSegmentationRequest request);
        partial void ProcessSamSegmentImageSamSegmentImagePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSamSegmentImageSamSegmentImagePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SAM Image Segmentation<br/>
        /// Run the Meta AI Segmant Anything Model to generate segmenations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SamSegmentationResponse> SamSegmentImageSamSegmentImagePostAsync(

            global::G.SamSegmentationRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSamSegmentImageSamSegmentImagePostArguments(
                httpClient: HttpClient,
                apiKey: ref apiKey,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/sam/segment_image",
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
            PrepareSamSegmentImageSamSegmentImagePostRequest(
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
            ProcessSamSegmentImageSamSegmentImagePostResponse(
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
                ProcessSamSegmentImageSamSegmentImagePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SamSegmentationResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SamSegmentationResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// SAM Image Segmentation<br/>
        /// Run the Meta AI Segmant Anything Model to generate segmenations for image data.
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
        /// <param name="samVersionId">
        /// The version ID of SAM to be used for this request. Must be one of vit_h, vit_l, or vit_b.<br/>
        /// Default Value: vit_h
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="embeddings">
        /// The embeddings to be decoded. The dimensions of the embeddings are 1 x 256 x 64 x 64. If embeddings is not provided, image must be provided.
        /// </param>
        /// <param name="embeddingsFormat">
        /// The format of the embeddings. Must be one of json or binary. If binary, embeddings are expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="format">
        /// The format of the response. Must be one of json or binary. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons, then returned as json.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The image to be segmented. Only required if embeddings are not provided.
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </param>
        /// <param name="hasMaskInput">
        /// Whether or not the request includes a mask input. If true, the mask input must be provided.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maskInput">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256. This is the same as the output, low resolution mask from the previous inference.
        /// </param>
        /// <param name="maskInputFormat">
        /// The format of the mask input. Must be one of json or binary. If binary, mask input is expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="origImSize">
        /// The original size of the image used to generate the embeddings. This is only required if the image is not provided.
        /// </param>
        /// <param name="pointCoords">
        /// The coordinates of the interactive points used during decoding. Each point (x,y pair) corresponds to a label in point_labels.<br/>
        /// Default Value: [[0F, 0F]]
        /// </param>
        /// <param name="pointLabels">
        /// The labels of the interactive points used during decoding. A 1 represents a positive point (part of the object to be segmented). A -1 represents a negative point (not part of the object to be segmented). Each label corresponds to a point in point_coords.<br/>
        /// Default Value: [-1]
        /// </param>
        /// <param name="useMaskInputCache">
        /// Whether or not to use the mask input cache. If true, the mask input cache will be used if it exists. If false, the mask input cache will not be used.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SamSegmentationResponse> SamSegmentImageSamSegmentImagePostAsync(
            string id,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? samVersionId = default,
            string? modelId = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? embeddings = default,
            string? embeddingsFormat = default,
            string? format = default,
            global::G.InferenceRequestImage? image = default,
            string? imageId = default,
            bool? hasMaskInput = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? maskInput = default,
            string? maskInputFormat = default,
            global::System.Collections.Generic.IList<int>? origImSize = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? pointCoords = default,
            global::System.Collections.Generic.IList<double>? pointLabels = default,
            bool? useMaskInputCache = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.SamSegmentationRequest
            {
                Id = id,
                ApiKey = requestApiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                SamVersionId = samVersionId,
                ModelId = modelId,
                Embeddings = embeddings,
                EmbeddingsFormat = embeddingsFormat,
                Format = format,
                Image = image,
                ImageId = imageId,
                HasMaskInput = hasMaskInput,
                MaskInput = maskInput,
                MaskInputFormat = maskInputFormat,
                OrigImSize = origImSize,
                PointCoords = pointCoords,
                PointLabels = pointLabels,
                UseMaskInputCache = useMaskInputCache,
            };

            return await SamSegmentImageSamSegmentImagePostAsync(
                apiKey: apiKey,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}