//HintName: G.Models.CreateImageToVideoRequestVeo3.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestVeo3
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptImage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>> PromptImage { get; set; } = default!;

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        /// <default>8</default>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double Duration { get; set; } = 8;

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ratio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateImageToVideoRequestVeo3Ratio Ratio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"veo3"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "veo3";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="promptImage"></param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="model"></param>
        public CreateImageToVideoRequestVeo3(
            global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>> promptImage,
            global::G.CreateImageToVideoRequestVeo3Ratio ratio,
            string? promptText,
            double duration = 8,
            string model = "veo3")
        {
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.PromptText = promptText;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3" /> class.
        /// </summary>
        public CreateImageToVideoRequestVeo3()
        {
        }
    }
}