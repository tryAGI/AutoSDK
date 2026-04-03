//HintName: G.Api.LegacyInferFromRequestDatasetIdVersionIdGet.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareLegacyInferFromRequestDatasetIdVersionIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref string versionId,
            ref string? apiKey,
            ref double? confidence,
            ref double? keypointConfidence,
            ref string? format,
            ref string? image,
            ref string? imageType,
            bool? labels,
            ref string? maskDecodeMode,
            double? tradeoffFactor,
            ref int? maxDetections,
            ref double? overlap,
            ref int? stroke,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            bool? disableActiveLearning,
            ref string? activeLearningTargetDataset,
            ref string? source,
            ref string? sourceInfo);
        partial void PrepareLegacyInferFromRequestDatasetIdVersionIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            string versionId,
            string? apiKey,
            double? confidence,
            double? keypointConfidence,
            string? format,
            string? image,
            string? imageType,
            bool? labels,
            string? maskDecodeMode,
            double? tradeoffFactor,
            int? maxDetections,
            double? overlap,
            int? stroke,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            bool? disableActiveLearning,
            string? activeLearningTargetDataset,
            string? source,
            string? sourceInfo);
        partial void ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Legacy Infer From Request<br/>
        /// Legacy inference endpoint for object detection, instance segmentation, and classification.<br/>
        /// Args:<br/>
        ///     background_tasks: (BackgroundTasks) pool of fastapi background tasks<br/>
        ///     dataset_id (str): ID of a Roboflow dataset corresponding to the model to use for inference OR workspace ID<br/>
        ///     version_id (str): ID of a Roboflow dataset version corresponding to the model to use for inference OR model ID<br/>
        ///     api_key (Optional[str], default None): Roboflow API Key passed to the model during initialization for artifact retrieval.<br/>
        ///     # Other parameters described in the function signature...<br/>
        /// Returns:<br/>
        ///     Union[InstanceSegmentationInferenceResponse, KeypointsDetectionInferenceRequest, ObjectDetectionInferenceResponse, ClassificationInferenceResponse, MultiLabelClassificationInferenceResponse, SemanticSegmentationInferenceResponse, Any]: The response containing the inference results.
        /// </summary>
        /// <param name="datasetId">
        /// ID of a Roboflow dataset corresponding to the model to use for inference OR workspace ID
        /// </param>
        /// <param name="versionId">
        /// ID of a Roboflow dataset version corresponding to the model to use for inference OR model ID
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="confidence">
        /// The confidence threshold used to filter out predictions<br/>
        /// Default Value: 0.4F
        /// </param>
        /// <param name="keypointConfidence">
        /// The confidence threshold used to filter out keypoints that are not visible based on model confidence<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="format">
        /// One of 'json' or 'image'. If 'json' prediction data is return as a JSON string. If 'image' prediction data is visualized and overlayed on the original input image.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The publically accessible URL of an image to use for inference.
        /// </param>
        /// <param name="imageType">
        /// One of base64 or numpy. Note, numpy input is not supported for Roboflow Hosted Inference.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="labels">
        /// If true, labels will be include in any inference visualization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maskDecodeMode">
        /// One of 'accurate' or 'fast'. If 'accurate' the mask will be decoded using the original image size. If 'fast' the mask will be decoded using the original mask size. 'accurate' is slower but more accurate.<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="tradeoffFactor">
        /// The amount to tradeoff between 0='fast' and 1='accurate'<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxDetections">
        /// The maximum number of detections to return. This is used to limit the number of predictions returned by the model. The model may return more predictions than this number, but only the top `max_detections` predictions will be returned.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="overlap">
        /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stroke">
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="disablePreprocAutoOrient">
        /// If true, disables automatic image orientation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocContrast">
        /// If true, disables automatic contrast adjustment<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocGrayscale">
        /// If true, disables automatic grayscale conversion<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocStaticCrop">
        /// If true, disables automatic static crop<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableActiveLearning">
        /// If true, the predictions will be prevented from registration by Active Learning (if the functionality is enabled)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="activeLearningTargetDataset">
        /// Parameter to be used when Active Learning data registration should happen against different dataset than the one pointed by model_id
        /// </param>
        /// <param name="source">
        /// The source of the inference request<br/>
        /// Default Value: external
        /// </param>
        /// <param name="sourceInfo">
        /// The detailed source information of the inference request<br/>
        /// Default Value: external
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>> LegacyInferFromRequestDatasetIdVersionIdGetAsync(
            string datasetId,
            string versionId,
            string? apiKey = default,
            double? confidence = default,
            double? keypointConfidence = default,
            string? format = default,
            string? image = default,
            string? imageType = default,
            bool? labels = default,
            string? maskDecodeMode = default,
            double? tradeoffFactor = default,
            int? maxDetections = default,
            double? overlap = default,
            int? stroke = default,
            bool? disablePreprocAutoOrient = default,
            bool? disablePreprocContrast = default,
            bool? disablePreprocGrayscale = default,
            bool? disablePreprocStaticCrop = default,
            bool? disableActiveLearning = default,
            string? activeLearningTargetDataset = default,
            string? source = default,
            string? sourceInfo = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareLegacyInferFromRequestDatasetIdVersionIdGetArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                versionId: ref versionId,
                apiKey: ref apiKey,
                confidence: ref confidence,
                keypointConfidence: ref keypointConfidence,
                format: ref format,
                image: ref image,
                imageType: ref imageType,
                labels: labels,
                maskDecodeMode: ref maskDecodeMode,
                tradeoffFactor: tradeoffFactor,
                maxDetections: ref maxDetections,
                overlap: ref overlap,
                stroke: ref stroke,
                disablePreprocAutoOrient: disablePreprocAutoOrient,
                disablePreprocContrast: disablePreprocContrast,
                disablePreprocGrayscale: disablePreprocGrayscale,
                disablePreprocStaticCrop: disablePreprocStaticCrop,
                disableActiveLearning: disableActiveLearning,
                activeLearningTargetDataset: ref activeLearningTargetDataset,
                source: ref source,
                sourceInfo: ref sourceInfo);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/{datasetId}/{versionId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("api_key", apiKey)
                .AddOptionalParameter("confidence", confidence?.ToString())
                .AddOptionalParameter("keypoint_confidence", keypointConfidence?.ToString())
                .AddOptionalParameter("format", format)
                .AddOptionalParameter("image", image)
                .AddOptionalParameter("image_type", imageType)
                .AddOptionalParameter("labels", labels?.ToString().ToLowerInvariant())
                .AddOptionalParameter("mask_decode_mode", maskDecodeMode)
                .AddOptionalParameter("tradeoff_factor", tradeoffFactor?.ToString())
                .AddOptionalParameter("max_detections", maxDetections?.ToString())
                .AddOptionalParameter("overlap", overlap?.ToString())
                .AddOptionalParameter("stroke", stroke?.ToString())
                .AddOptionalParameter("disable_preproc_auto_orient", disablePreprocAutoOrient?.ToString().ToLowerInvariant())
                .AddOptionalParameter("disable_preproc_contrast", disablePreprocContrast?.ToString().ToLowerInvariant())
                .AddOptionalParameter("disable_preproc_grayscale", disablePreprocGrayscale?.ToString().ToLowerInvariant())
                .AddOptionalParameter("disable_preproc_static_crop", disablePreprocStaticCrop?.ToString().ToLowerInvariant())
                .AddOptionalParameter("disable_active_learning", disableActiveLearning?.ToString().ToLowerInvariant())
                .AddOptionalParameter("active_learning_target_dataset", activeLearningTargetDataset)
                .AddOptionalParameter("source", source)
                .AddOptionalParameter("source_info", sourceInfo) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareLegacyInferFromRequestDatasetIdVersionIdGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                versionId: versionId,
                apiKey: apiKey,
                confidence: confidence,
                keypointConfidence: keypointConfidence,
                format: format,
                image: image,
                imageType: imageType,
                labels: labels,
                maskDecodeMode: maskDecodeMode,
                tradeoffFactor: tradeoffFactor,
                maxDetections: maxDetections,
                overlap: overlap,
                stroke: stroke,
                disablePreprocAutoOrient: disablePreprocAutoOrient,
                disablePreprocContrast: disablePreprocContrast,
                disablePreprocGrayscale: disablePreprocGrayscale,
                disablePreprocStaticCrop: disablePreprocStaticCrop,
                disableActiveLearning: disableActiveLearning,
                activeLearningTargetDataset: activeLearningTargetDataset,
                source: source,
                sourceInfo: sourceInfo);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponse(
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
                ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}