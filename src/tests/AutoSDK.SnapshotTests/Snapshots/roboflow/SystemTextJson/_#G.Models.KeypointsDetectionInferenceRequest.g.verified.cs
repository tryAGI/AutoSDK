//HintName: G.Models.KeypointsDetectionInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeypointsDetectionInferenceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </summary>
        /// <example>raccoon-detector-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The type of the model, usually referring to what task the model performs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; }

        /// <summary>
        /// If true, the auto orient preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_auto_orient")]
        public bool? DisablePreprocAutoOrient { get; set; }

        /// <summary>
        /// If true, the auto contrast preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_contrast")]
        public bool? DisablePreprocContrast { get; set; }

        /// <summary>
        /// If true, the grayscale preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_grayscale")]
        public bool? DisablePreprocGrayscale { get; set; }

        /// <summary>
        /// If true, the static crop preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_static_crop")]
        public bool? DisablePreprocStaticCrop { get; set; }

        /// <summary>
        /// If true, NMS is applied to all detections at once, if false, NMS is applied per class<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_agnostic_nms")]
        public bool? ClassAgnosticNms { get; set; }

        /// <summary>
        /// If provided, only predictions for the listed classes will be returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_filter")]
        public global::System.Collections.Generic.IList<string>? ClassFilter { get; set; }

        /// <summary>
        /// The confidence threshold used to filter out predictions<br/>
        /// Default Value: 0.4F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// If true, the batch size will be fixed to the maximum batch size configured for this server<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_batch_size")]
        public bool? FixBatchSize { get; set; }

        /// <summary>
        /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou_threshold")]
        public double? IouThreshold { get; set; }

        /// <summary>
        /// The maximum number of detections that will be returned<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_detections")]
        public int? MaxDetections { get; set; }

        /// <summary>
        /// The maximum number of candidate detections passed to NMS<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_candidates")]
        public int? MaxCandidates { get; set; }

        /// <summary>
        /// If true, labels will be rendered on prediction visualizations<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_labels")]
        public bool? VisualizationLabels { get; set; }

        /// <summary>
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_stroke_width")]
        public int? VisualizationStrokeWidth { get; set; }

        /// <summary>
        /// If true, the predictions will be drawn on the original image and returned as a base64 string<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualize_predictions")]
        public bool? VisualizePredictions { get; set; }

        /// <summary>
        /// If true, the predictions will be prevented from registration by Active Learning (if the functionality is enabled)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_active_learning")]
        public bool? DisableActiveLearning { get; set; }

        /// <summary>
        /// Parameter to be used when Active Learning data registration should happen against different dataset than the one pointed by model_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_learning_target_dataset")]
        public string? ActiveLearningTargetDataset { get; set; }

        /// <summary>
        /// The confidence threshold used to filter out non visible keypoints<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypoint_confidence")]
        public double? KeypointConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypointsDetectionInferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image"></param>
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
        /// <param name="keypointConfidence">
        /// The confidence threshold used to filter out non visible keypoints<br/>
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeypointsDetectionInferenceRequest(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? modelId,
            string? modelType,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            bool? classAgnosticNms,
            global::System.Collections.Generic.IList<string>? classFilter,
            double? confidence,
            bool? fixBatchSize,
            double? iouThreshold,
            int? maxDetections,
            int? maxCandidates,
            bool? visualizationLabels,
            int? visualizationStrokeWidth,
            bool? visualizePredictions,
            bool? disableActiveLearning,
            string? activeLearningTargetDataset,
            double? keypointConfidence)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.ModelId = modelId;
            this.ModelType = modelType;
            this.Image = image;
            this.DisablePreprocAutoOrient = disablePreprocAutoOrient;
            this.DisablePreprocContrast = disablePreprocContrast;
            this.DisablePreprocGrayscale = disablePreprocGrayscale;
            this.DisablePreprocStaticCrop = disablePreprocStaticCrop;
            this.ClassAgnosticNms = classAgnosticNms;
            this.ClassFilter = classFilter;
            this.Confidence = confidence;
            this.FixBatchSize = fixBatchSize;
            this.IouThreshold = iouThreshold;
            this.MaxDetections = maxDetections;
            this.MaxCandidates = maxCandidates;
            this.VisualizationLabels = visualizationLabels;
            this.VisualizationStrokeWidth = visualizationStrokeWidth;
            this.VisualizePredictions = visualizePredictions;
            this.DisableActiveLearning = disableActiveLearning;
            this.ActiveLearningTargetDataset = activeLearningTargetDataset;
            this.KeypointConfidence = keypointConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypointsDetectionInferenceRequest" /> class.
        /// </summary>
        public KeypointsDetectionInferenceRequest()
        {
        }
    }
}