//HintName: G.Models.CreateTaskRequestVariant9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant9TypeJsonConverter))]
        public global::G.CreateTaskRequestVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant9FormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateTaskRequestVariant9Format Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalModelTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_symmetry")]
        public bool? ForceSymmetry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom")]
        public bool? FlattenBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom_threshold")]
        public double? FlattenBottomThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant9TextureFormatJsonConverter))]
        public global::G.CreateTaskRequestVariant9TextureFormat? TextureFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pivot_to_center_bottom")]
        public bool? PivotToCenterBottom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant9" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="originalModelTaskId"></param>
        /// <param name="type"></param>
        /// <param name="quad"></param>
        /// <param name="forceSymmetry"></param>
        /// <param name="faceLimit"></param>
        /// <param name="flattenBottom"></param>
        /// <param name="flattenBottomThreshold"></param>
        /// <param name="textureSize"></param>
        /// <param name="textureFormat"></param>
        /// <param name="pivotToCenterBottom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant9(
            global::G.CreateTaskRequestVariant9Format format,
            string originalModelTaskId,
            global::G.CreateTaskRequestVariant9Type type,
            bool? quad,
            bool? forceSymmetry,
            int? faceLimit,
            bool? flattenBottom,
            double? flattenBottomThreshold,
            int? textureSize,
            global::G.CreateTaskRequestVariant9TextureFormat? textureFormat,
            bool? pivotToCenterBottom)
        {
            this.Type = type;
            this.Format = format;
            this.OriginalModelTaskId = originalModelTaskId ?? throw new global::System.ArgumentNullException(nameof(originalModelTaskId));
            this.Quad = quad;
            this.ForceSymmetry = forceSymmetry;
            this.FaceLimit = faceLimit;
            this.FlattenBottom = flattenBottom;
            this.FlattenBottomThreshold = flattenBottomThreshold;
            this.TextureSize = textureSize;
            this.TextureFormat = textureFormat;
            this.PivotToCenterBottom = pivotToCenterBottom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant9" /> class.
        /// </summary>
        public CreateTaskRequestVariant9()
        {
        }
    }
}