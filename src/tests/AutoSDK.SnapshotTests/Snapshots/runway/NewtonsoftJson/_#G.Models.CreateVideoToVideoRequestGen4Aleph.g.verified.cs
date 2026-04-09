//HintName: G.Models.CreateVideoToVideoRequestGen4Aleph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGen4Aleph
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("videoUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoUri { get; set; } = default!;

        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptText", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptText { get; set; } = default!;

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ratio", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioJsonConverter))]
        public global::G.CreateVideoToVideoRequestGen4AlephRatio Ratio { get; set; } = default!;

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// An array of references. Currently up to one reference is supported. See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references")]
        public global::System.Collections.Generic.IList<global::G.ReferencesItem>? References { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentModeration")]
        public global::G.CreateVideoToVideoRequestGen4AlephContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gen4_aleph"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "gen4_aleph";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4Aleph" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="references">
        /// An array of references. Currently up to one reference is supported. See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="model"></param>
        public CreateVideoToVideoRequestGen4Aleph(
            string videoUri,
            string promptText,
            global::G.CreateVideoToVideoRequestGen4AlephRatio ratio,
            int? seed,
            global::System.Collections.Generic.IList<global::G.ReferencesItem>? references,
            global::G.CreateVideoToVideoRequestGen4AlephContentModeration? contentModeration,
            string model = "gen4_aleph")
        {
            this.VideoUri = videoUri;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Seed = seed;
            this.References = references;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4Aleph" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGen4Aleph()
        {
        }
    }
}