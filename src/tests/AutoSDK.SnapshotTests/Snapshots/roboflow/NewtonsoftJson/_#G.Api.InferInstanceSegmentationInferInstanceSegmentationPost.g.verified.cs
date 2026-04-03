//HintName: G.Api.InferInstanceSegmentationInferInstanceSegmentationPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareInferInstanceSegmentationInferInstanceSegmentationPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            bool? countinference,
            ref string? serviceSecret,
            global::G.InstanceSegmentationInferenceRequest request);
        partial void PrepareInferInstanceSegmentationInferInstanceSegmentationPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? countinference,
            string? serviceSecret,
            global::G.InstanceSegmentationInferenceRequest request);
        partial void ProcessInferInstanceSegmentationInferInstanceSegmentationPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInferInstanceSegmentationInferInstanceSegmentationPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Instance segmentation infer<br/>
        /// Run inference with the specified instance segmentation model
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.StubResponse>> InferInstanceSegmentationInferInstanceSegmentationPostAsync(

            global::G.InstanceSegmentationInferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInferInstanceSegmentationInferInstanceSegmentationPostArguments(
                httpClient: HttpClient,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/infer/instance_segmentation",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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
            PrepareInferInstanceSegmentationInferInstanceSegmentationPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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
            ProcessInferInstanceSegmentationInferInstanceSegmentationPostResponse(
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
                ProcessInferInstanceSegmentationInferInstanceSegmentationPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.StubResponse>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.StubResponse>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Instance segmentation infer<br/>
        /// Run inference with the specified instance segmentation model
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="apiKey">
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
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
        /// <param name="modelType">
        /// The type of the model, usually referring to what task the model performs
        /// </param>
        /// <param name="image"></param>
        /// <param name="disablePreprocAutoOrient">
        /// If true, the auto orient preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocContrast">
        /// If true, the auto contrast preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocGrayscale">
        /// If true, the grayscale preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocStaticCrop">
        /// If true, the static crop preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="classAgnosticNms">
        /// If true, NMS is applied to all detections at once, if false, NMS is applied per class<br/>
        /// Default Value: false
        /// </param>
        /// <param name="classFilter">
        /// If provided, only predictions for the listed classes will be returned
        /// </param>
        /// <param name="confidence">
        /// The confidence threshold used to filter out predictions<br/>
        /// Default Value: 0.4F
        /// </param>
        /// <param name="fixBatchSize">
        /// If true, the batch size will be fixed to the maximum batch size configured for this server<br/>
        /// Default Value: false
        /// </param>
        /// <param name="iouThreshold">
        /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="maxDetections">
        /// The maximum number of detections that will be returned<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="maxCandidates">
        /// The maximum number of candidate detections passed to NMS<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="visualizationLabels">
        /// If true, labels will be rendered on prediction visualizations<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualizationStrokeWidth">
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="visualizePredictions">
        /// If true, the predictions will be drawn on the original image and returned as a base64 string<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableActiveLearning">
        /// If true, the predictions will be prevented from registration by Active Learning (if the functionality is enabled)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="activeLearningTargetDataset">
        /// Parameter to be used when Active Learning data registration should happen against different dataset than the one pointed by model_id
        /// </param>
        /// <param name="maskDecodeMode">
        /// The mode used to decode instance segmentation masks, one of 'accurate', 'fast', 'tradeoff'<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="tradeoffFactor">
        /// The amount to tradeoff between 0='fast' and 1='accurate'<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.StubResponse>> InferInstanceSegmentationInferInstanceSegmentationPostAsync(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? modelId = default,
            string? modelType = default,
            bool? disablePreprocAutoOrient = default,
            bool? disablePreprocContrast = default,
            bool? disablePreprocGrayscale = default,
            bool? disablePreprocStaticCrop = default,
            bool? classAgnosticNms = default,
            global::System.Collections.Generic.IList<string>? classFilter = default,
            double? confidence = default,
            bool? fixBatchSize = default,
            double? iouThreshold = default,
            int? maxDetections = default,
            int? maxCandidates = default,
            bool? visualizationLabels = default,
            int? visualizationStrokeWidth = default,
            bool? visualizePredictions = default,
            bool? disableActiveLearning = default,
            string? activeLearningTargetDataset = default,
            string? maskDecodeMode = default,
            double? tradeoffFactor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.InstanceSegmentationInferenceRequest
            {
                Id = id,
                ApiKey = apiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                ModelId = modelId,
                ModelType = modelType,
                Image = image,
                DisablePreprocAutoOrient = disablePreprocAutoOrient,
                DisablePreprocContrast = disablePreprocContrast,
                DisablePreprocGrayscale = disablePreprocGrayscale,
                DisablePreprocStaticCrop = disablePreprocStaticCrop,
                ClassAgnosticNms = classAgnosticNms,
                ClassFilter = classFilter,
                Confidence = confidence,
                FixBatchSize = fixBatchSize,
                IouThreshold = iouThreshold,
                MaxDetections = maxDetections,
                MaxCandidates = maxCandidates,
                VisualizationLabels = visualizationLabels,
                VisualizationStrokeWidth = visualizationStrokeWidth,
                VisualizePredictions = visualizePredictions,
                DisableActiveLearning = disableActiveLearning,
                ActiveLearningTargetDataset = activeLearningTargetDataset,
                MaskDecodeMode = maskDecodeMode,
                TradeoffFactor = tradeoffFactor,
            };

            return await InferInstanceSegmentationInferInstanceSegmentationPostAsync(
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}