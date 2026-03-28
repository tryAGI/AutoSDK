//HintName: G.Models.CreateImageToVideoRequestGen4Turbo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGen4Turbo
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
        public global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>> PromptImage { get; set; } = default!;

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ratio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateImageToVideoRequestGen4TurboRatio Ratio { get; set; } = default!;

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentModeration")]
        public global::G.CreateImageToVideoRequestGen4TurboContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gen4_turbo"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "gen4_turbo";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen4Turbo" /> class.
        /// </summary>
        /// <param name="promptImage"></param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="model"></param>
        public CreateImageToVideoRequestGen4Turbo(
            global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>> promptImage,
            global::G.CreateImageToVideoRequestGen4TurboRatio ratio,
            string? promptText,
            int? seed,
            int? duration,
            global::G.CreateImageToVideoRequestGen4TurboContentModeration? contentModeration,
            string model = "gen4_turbo")
        {
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Seed = seed;
            this.Ratio = ratio;
            this.Duration = duration;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen4Turbo" /> class.
        /// </summary>
        public CreateImageToVideoRequestGen4Turbo()
        {
        }
    }
}