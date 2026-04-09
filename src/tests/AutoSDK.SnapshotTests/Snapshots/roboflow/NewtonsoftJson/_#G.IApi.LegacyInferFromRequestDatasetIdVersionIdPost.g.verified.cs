//HintName: G.IApi.LegacyInferFromRequestDatasetIdVersionIdPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>> LegacyInferFromRequestDatasetIdVersionIdPostAsync(
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}