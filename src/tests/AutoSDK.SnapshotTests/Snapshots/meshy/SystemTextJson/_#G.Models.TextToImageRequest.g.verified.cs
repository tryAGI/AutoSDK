//HintName: G.Models.TextToImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageAiModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageAiModel AiModel { get; set; }

        /// <summary>
        /// Text description for image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Generate multi-angle views (cannot use with aspect_ratio)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_multi_view")]
        public bool? GenerateMultiView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pose_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToImageRequestPoseModeJsonConverter))]
        public global::G.TextToImageRequestPoseMode? PoseMode { get; set; }

        /// <summary>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AspectRatioJsonConverter))]
        public global::G.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequest" /> class.
        /// </summary>
        /// <param name="aiModel"></param>
        /// <param name="prompt">
        /// Text description for image generation
        /// </param>
        /// <param name="generateMultiView">
        /// Generate multi-angle views (cannot use with aspect_ratio)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageRequest(
            global::G.ImageAiModel aiModel,
            string prompt,
            bool? generateMultiView,
            global::G.TextToImageRequestPoseMode? poseMode,
            global::G.AspectRatio? aspectRatio)
        {
            this.AiModel = aiModel;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.GenerateMultiView = generateMultiView;
            this.PoseMode = poseMode;
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequest" /> class.
        /// </summary>
        public TextToImageRequest()
        {
        }
    }
}