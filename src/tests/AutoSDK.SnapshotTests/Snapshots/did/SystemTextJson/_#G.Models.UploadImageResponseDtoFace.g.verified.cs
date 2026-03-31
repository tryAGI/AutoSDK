//HintName: G.Models.UploadImageResponseDtoFace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadImageResponseDtoFace
    {
        /// <summary>
        /// Size of the square side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Top left location of the face in the frame - can be negative
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> TopLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadImageResponseDtoFaceOverlapJsonConverter))]
        public global::G.UploadImageResponseDtoFaceOverlap? Overlap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        public string? FaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_confidence")]
        public double? DetectConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpness")]
        public double? Sharpness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_occluded")]
        public bool? FaceOccluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_occluded_confidence")]
        public double? FaceOccludedConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection")]
        public global::G.UploadImageResponseDtoFaceDetection? Detection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageResponseDtoFace" /> class.
        /// </summary>
        /// <param name="size">
        /// Size of the square side
        /// </param>
        /// <param name="topLeft">
        /// Top left location of the face in the frame - can be negative
        /// </param>
        /// <param name="overlap"></param>
        /// <param name="faceId"></param>
        /// <param name="detectConfidence"></param>
        /// <param name="sharpness"></param>
        /// <param name="faceOccluded"></param>
        /// <param name="faceOccludedConfidence"></param>
        /// <param name="detection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadImageResponseDtoFace(
            int size,
            global::System.Collections.Generic.IList<double> topLeft,
            global::G.UploadImageResponseDtoFaceOverlap? overlap,
            string? faceId,
            double? detectConfidence,
            double? sharpness,
            bool? faceOccluded,
            double? faceOccludedConfidence,
            global::G.UploadImageResponseDtoFaceDetection? detection)
        {
            this.Size = size;
            this.TopLeft = topLeft ?? throw new global::System.ArgumentNullException(nameof(topLeft));
            this.Overlap = overlap;
            this.FaceId = faceId;
            this.DetectConfidence = detectConfidence;
            this.Sharpness = sharpness;
            this.FaceOccluded = faceOccluded;
            this.FaceOccludedConfidence = faceOccludedConfidence;
            this.Detection = detection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageResponseDtoFace" /> class.
        /// </summary>
        public UploadImageResponseDtoFace()
        {
        }
    }
}