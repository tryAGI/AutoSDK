//HintName: G.Models.FaceModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceModelConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps_pred")]
        public double? FpsPred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prob_threshold")]
        public double? ProbThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identify_faces")]
        public bool? IdentifyFaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_face_size")]
        public int? MinFaceSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("facs")]
        public object? Facs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptions")]
        public object? Descriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save_faces")]
        public bool? SaveFaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceModelConfig" /> class.
        /// </summary>
        /// <param name="fpsPred"></param>
        /// <param name="probThreshold"></param>
        /// <param name="identifyFaces"></param>
        /// <param name="minFaceSize"></param>
        /// <param name="facs"></param>
        /// <param name="descriptions"></param>
        /// <param name="saveFaces"></param>
        public FaceModelConfig(
            double? fpsPred,
            double? probThreshold,
            bool? identifyFaces,
            int? minFaceSize,
            object? facs,
            object? descriptions,
            bool? saveFaces)
        {
            this.FpsPred = fpsPred;
            this.ProbThreshold = probThreshold;
            this.IdentifyFaces = identifyFaces;
            this.MinFaceSize = minFaceSize;
            this.Facs = facs;
            this.Descriptions = descriptions;
            this.SaveFaces = saveFaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceModelConfig" /> class.
        /// </summary>
        public FaceModelConfig()
        {
        }
    }
}