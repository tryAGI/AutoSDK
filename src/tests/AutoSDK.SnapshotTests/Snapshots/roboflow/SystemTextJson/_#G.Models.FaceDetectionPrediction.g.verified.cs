//HintName: G.Models.FaceDetectionPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Face Detection prediction.<br/>
    /// Attributes:<br/>
    ///     class_name (str): fixed value "face".<br/>
    ///     landmarks (Union[List[inference.core.entities.responses.inference.Point], List[inference.core.entities.responses.inference.Point3D]]): The detected face landmarks.
    /// </summary>
    public sealed partial class FaceDetectionPrediction
    {
        /// <summary>
        /// The center x-axis pixel coordinate of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// The center y-axis pixel coordinate of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// The width of the prediction bounding box in number of pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// The height of the prediction bounding box in number of pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// The detection confidence as a fraction between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The predicted class label<br/>
        /// Default Value: face
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// The class label confidence as a fraction between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_confidence")]
        public double? ClassConfidence { get; set; }

        /// <summary>
        /// The class id of the prediction<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_id")]
        public int? ClassId { get; set; }

        /// <summary>
        /// The tracker id of the prediction if tracking is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracker_id")]
        public int? TrackerId { get; set; }

        /// <summary>
        /// Unique identifier of detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_id")]
        public string? DetectionId { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landmarks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PointOutput>, global::System.Collections.Generic.IList<global::G.Point3D>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PointOutput>, global::System.Collections.Generic.IList<global::G.Point3D>> Landmarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionPrediction" /> class.
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
        /// <param name="landmarks"></param>
        /// <param name="class">
        /// The predicted class label<br/>
        /// Default Value: face
        /// </param>
        /// <param name="classConfidence">
        /// The class label confidence as a fraction between 0 and 1
        /// </param>
        /// <param name="classId">
        /// The class id of the prediction<br/>
        /// Default Value: 0
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionPrediction(
            double x,
            double y,
            double width,
            double height,
            double confidence,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PointOutput>, global::System.Collections.Generic.IList<global::G.Point3D>> landmarks,
            string? @class,
            double? classConfidence,
            int? classId,
            int? trackerId,
            string? detectionId,
            string? parentId)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Confidence = confidence;
            this.Class = @class;
            this.ClassConfidence = classConfidence;
            this.ClassId = classId;
            this.TrackerId = trackerId;
            this.DetectionId = detectionId;
            this.ParentId = parentId;
            this.Landmarks = landmarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionPrediction" /> class.
        /// </summary>
        public FaceDetectionPrediction()
        {
        }
    }
}