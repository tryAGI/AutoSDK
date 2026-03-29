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
        [global::Newtonsoft.Json.JsonProperty("ai_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageAiModel AiModel { get; set; } = default!;

        /// <summary>
        /// Text description for image generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Generate multi-angle views (cannot use with aspect_ratio)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generate_multi_view")]
        public bool? GenerateMultiView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pose_mode")]
        public global::G.TextToImageRequestPoseMode? PoseMode { get; set; }

        /// <summary>
        /// Default Value: 1:1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public global::G.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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