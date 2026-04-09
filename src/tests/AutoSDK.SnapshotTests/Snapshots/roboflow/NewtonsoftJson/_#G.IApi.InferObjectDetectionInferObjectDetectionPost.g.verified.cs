//HintName: G.IApi.InferObjectDetectionInferObjectDetectionPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Object detection infer<br/>
        /// Run inference with the specified object detection model
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::G.ObjectDetectionInferenceResponse>, global::G.StubResponse>> InferObjectDetectionInferObjectDetectionPostAsync(

            global::G.ObjectDetectionInferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Object detection infer<br/>
        /// Run inference with the specified object detection model
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::G.ObjectDetectionInferenceResponse>, global::G.StubResponse>> InferObjectDetectionInferObjectDetectionPostAsync(
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}