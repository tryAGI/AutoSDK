//HintName: G.Models.KeypointsPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeypointsPrediction
    {
        /// <summary>
        /// The center x-axis pixel coordinate of the prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public double X { get; set; } = default!;

        /// <summary>
        /// The center y-axis pixel coordinate of the prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y { get; set; } = default!;

        /// <summary>
        /// The width of the prediction bounding box in number of pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// The height of the prediction bounding box in number of pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public double Height { get; set; } = default!;

        /// <summary>
        /// The detection confidence as a fraction between 0 and 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// The predicted class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class", Required = global::Newtonsoft.Json.Required.Always)]
        public string Class { get; set; } = default!;

        /// <summary>
        /// The class label confidence as a fraction between 0 and 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_confidence")]
        public double? ClassConfidence { get; set; }

        /// <summary>
        /// The class id of the prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClassId { get; set; } = default!;

        /// <summary>
        /// The tracker id of the prediction if tracking is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tracker_id")]
        public int? TrackerId { get; set; }

        /// <summary>
        /// Unique identifier of detection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detection_id")]
        public string? DetectionId { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keypoints", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Keypoint> Keypoints { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypointsPrediction" /> class.
        /// </summary>
        /// <param name="x">
        /// The center x-axis pixel coordinate of the prediction
        /// </param>
        /// <param name="y">
        /// The center y-axis pixel coordinate of the prediction
        /// </param>
        /// <param name="width">
        /// The width of the prediction bounding box in number of pixels
        /// </param>
        /// <param name="height">
        /// The height of the prediction bounding box in number of pixels
        /// </param>
        /// <param name="confidence">
        /// The detection confidence as a fraction between 0 and 1
        /// </param>
        /// <param name="class">
        /// The predicted class label
        /// </param>
        /// <param name="classId">
        /// The class id of the prediction
        /// </param>
        /// <param name="keypoints"></param>
        /// <param name="classConfidence">
        /// The class label confidence as a fraction between 0 and 1
        /// </param>
        /// <param name="trackerId">
        /// The tracker id of the prediction if tracking is enabled
        /// </param>
        /// <param name="detectionId">
        /// Unique identifier of detection
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
        public KeypointsPrediction(
            double x,
            double y,
            double width,
            double height,
            double confidence,
            string @class,
            int classId,
            global::System.Collections.Generic.IList<global::G.Keypoint> keypoints,
            double? classConfidence,
            int? trackerId,
            string? detectionId,
            string? parentId)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Confidence = confidence;
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
            this.ClassConfidence = classConfidence;
            this.ClassId = classId;
            this.TrackerId = trackerId;
            this.DetectionId = detectionId;
            this.ParentId = parentId;
            this.Keypoints = keypoints ?? throw new global::System.ArgumentNullException(nameof(keypoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypointsPrediction" /> class.
        /// </summary>
        public KeypointsPrediction()
        {
        }
    }
}