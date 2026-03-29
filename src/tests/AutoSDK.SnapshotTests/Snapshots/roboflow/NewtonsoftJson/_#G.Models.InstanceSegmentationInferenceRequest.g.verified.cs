//HintName: G.Models.InstanceSegmentationInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instance Segmentation inference request.<br/>
    /// Attributes:<br/>
    ///     mask_decode_mode (Optional[str]): The mode used to decode instance segmentation masks, one of 'accurate', 'fast', 'tradeoff'.<br/>
    ///     tradeoff_factor (Optional[float]): The amount to tradeoff between 0='fast' and 1='accurate'.
    /// </summary>
    public sealed partial class InstanceSegmentationInferenceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </summary>
        /// <example>raccoon-detector-1</example>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The type of the model, usually referring to what task the model performs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; } = default!;

        /// <summary>
        /// If true, the auto orient preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_preproc_auto_orient")]
        public bool? DisablePreprocAutoOrient { get; set; }

        /// <summary>
        /// If true, the auto contrast preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_preproc_contrast")]
        public bool? DisablePreprocContrast { get; set; }

        /// <summary>
        /// If true, the grayscale preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_preproc_grayscale")]
        public bool? DisablePreprocGrayscale { get; set; }

        /// <summary>
        /// If true, the static crop preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_preproc_static_crop")]
        public bool? DisablePreprocStaticCrop { get; set; }

        /// <summary>
        /// If true, NMS is applied to all detections at once, if false, NMS is applied per class<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_agnostic_nms")]
        public bool? ClassAgnosticNms { get; set; }

        /// <summary>
        /// If provided, only predictions for the listed classes will be returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_filter")]
        public global::System.Collections.Generic.IList<string>? ClassFilter { get; set; }

        /// <summary>
        /// The confidence threshold used to filter out predictions<br/>
        /// Default Value: 0.4F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// If true, the batch size will be fixed to the maximum batch size configured for this server<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fix_batch_size")]
        public bool? FixBatchSize { get; set; }

        /// <summary>
        /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iou_threshold")]
        public double? IouThreshold { get; set; }

        /// <summary>
        /// The maximum number of detections that will be returned<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_detections")]
        public int? MaxDetections { get; set; }

        /// <summary>
        /// The maximum number of candidate detections passed to NMS<br/>
        /// Default Value: 3000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_candidates")]
        public int? MaxCandidates { get; set; }

        /// <summary>
        /// If true, labels will be rendered on prediction visualizations<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visualization_labels")]
        public bool? VisualizationLabels { get; set; }

        /// <summary>
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visualization_stroke_width")]
        public int? VisualizationStrokeWidth { get; set; }

        /// <summary>
        /// If true, the predictions will be drawn on the original image and returned as a base64 string<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visualize_predictions")]
        public bool? VisualizePredictions { get; set; }

        /// <summary>
        /// If true, the predictions will be prevented from registration by Active Learning (if the functionality is enabled)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_active_learning")]
        public bool? DisableActiveLearning { get; set; }

        /// <summary>
        /// Parameter to be used when Active Learning data registration should happen against different dataset than the one pointed by model_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_learning_target_dataset")]
        public string? ActiveLearningTargetDataset { get; set; }

        /// <summary>
        /// The mode used to decode instance segmentation masks, one of 'accurate', 'fast', 'tradeoff'<br/>
        /// Default Value: accurate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_decode_mode")]
        public string? MaskDecodeMode { get; set; }

        /// <summary>
        /// The amount to tradeoff between 0='fast' and 1='accurate'<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tradeoff_factor")]
        public double? TradeoffFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationInferenceRequest" /> class.
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
        /// <param name="maskDecodeMode">
        /// The mode used to decode instance segmentation masks, one of 'accurate', 'fast', 'tradeoff'<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="tradeoffFactor">
        /// The amount to tradeoff between 0='fast' and 1='accurate'<br/>
        /// Default Value: 0F
        /// </param>
        public InstanceSegmentationInferenceRequest(
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
            string? maskDecodeMode,
            double? tradeoffFactor)
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
            this.MaskDecodeMode = maskDecodeMode;
            this.TradeoffFactor = tradeoffFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationInferenceRequest" /> class.
        /// </summary>
        public InstanceSegmentationInferenceRequest()
        {
        }
    }
}