//HintName: G.Models.InitTalkStreamRequestFace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the face to animate - otherwise detects the dominant face
    /// </summary>
    public sealed partial class InitTalkStreamRequestFace
    {
        /// <summary>
        /// Size of the square side
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Top left location of the face in the frame - can be negative
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> TopLeft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlap")]
        public global::G.InitTalkStreamRequestFaceOverlap? Overlap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_id")]
        public string? FaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detect_confidence")]
        public double? DetectConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharpness")]
        public double? Sharpness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_occluded")]
        public bool? FaceOccluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_occluded_confidence")]
        public double? FaceOccludedConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detection")]
        public global::G.InitTalkStreamRequestFaceDetection? Detection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTalkStreamRequestFace" /> class.
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
        public InitTalkStreamRequestFace(
            int size,
            global::System.Collections.Generic.IList<double> topLeft,
            global::G.InitTalkStreamRequestFaceOverlap? overlap,
            string? faceId,
            double? detectConfidence,
            double? sharpness,
            bool? faceOccluded,
            double? faceOccludedConfidence,
            global::G.InitTalkStreamRequestFaceDetection? detection)
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
        /// Initializes a new instance of the <see cref="InitTalkStreamRequestFace" /> class.
        /// </summary>
        public InitTalkStreamRequestFace()
        {
        }
    }
}