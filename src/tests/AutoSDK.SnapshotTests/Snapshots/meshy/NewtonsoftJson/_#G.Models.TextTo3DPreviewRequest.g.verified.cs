//HintName: G.Models.TextTo3DPreviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextTo3DPreviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextTo3DPreviewRequestModeJsonConverter))]
        public global::G.TextTo3DPreviewRequestMode Mode { get; set; }

        /// <summary>
        /// Description of the 3D object to generate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Default Value: standard
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelTypeJsonConverter))]
        public global::G.ModelType? ModelType { get; set; }

        /// <summary>
        /// Deprecated for Meshy-6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("art_style")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextTo3DPreviewRequestArtStyleJsonConverter))]
        public global::G.TextTo3DPreviewRequestArtStyle? ArtStyle { get; set; }

        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AiModelJsonConverter))]
        public global::G.AiModel? AiModel { get; set; }

        /// <summary>
        /// Default Value: triangle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topology")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TopologyJsonConverter))]
        public global::G.Topology? Topology { get; set; }

        /// <summary>
        /// Default Value: 30000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_polycount")]
        public int? TargetPolycount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("should_remesh")]
        public bool? ShouldRemesh { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("symmetry_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SymmetryModeJsonConverter))]
        public global::G.SymmetryMode? SymmetryMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pose_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PoseModeJsonConverter))]
        public global::G.PoseMode? PoseMode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_formats")]
        public global::System.Collections.Generic.IList<global::G.TargetFormat3D>? TargetFormats { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_at")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OriginAtJsonConverter))]
        public global::G.OriginAt? OriginAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DPreviewRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Description of the 3D object to generate
        /// </param>
        /// <param name="mode"></param>
        /// <param name="modelType">
        /// Default Value: standard
        /// </param>
        /// <param name="artStyle">
        /// Deprecated for Meshy-6
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="shouldRemesh">
        /// Default Value: false
        /// </param>
        /// <param name="symmetryMode">
        /// Default Value: auto
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="moderation">
        /// Default Value: false
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        public TextTo3DPreviewRequest(
            string prompt,
            global::G.TextTo3DPreviewRequestMode mode,
            global::G.ModelType? modelType,
            global::G.TextTo3DPreviewRequestArtStyle? artStyle,
            global::G.AiModel? aiModel,
            global::G.Topology? topology,
            int? targetPolycount,
            bool? shouldRemesh,
            global::G.SymmetryMode? symmetryMode,
            global::G.PoseMode? poseMode,
            bool? moderation,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats,
            bool? autoSize,
            global::G.OriginAt? originAt)
        {
            this.Mode = mode;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ModelType = modelType;
            this.ArtStyle = artStyle;
            this.AiModel = aiModel;
            this.Topology = topology;
            this.TargetPolycount = targetPolycount;
            this.ShouldRemesh = shouldRemesh;
            this.SymmetryMode = symmetryMode;
            this.PoseMode = poseMode;
            this.Moderation = moderation;
            this.TargetFormats = targetFormats;
            this.AutoSize = autoSize;
            this.OriginAt = originAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DPreviewRequest" /> class.
        /// </summary>
        public TextTo3DPreviewRequest()
        {
        }
    }
}