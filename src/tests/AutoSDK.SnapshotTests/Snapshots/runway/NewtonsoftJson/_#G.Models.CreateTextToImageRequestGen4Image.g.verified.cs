//HintName: G.Models.CreateTextToImageRequestGen4Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGen4Image
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptText", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptText { get; set; } = default!;

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ratio", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter))]
        public global::G.CreateTextToImageRequestGen4ImageRatio Ratio { get; set; } = default!;

        /// <summary>
        /// An array of up to three images to be used as references for the generated image output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceImages")]
        public global::System.Collections.Generic.IList<global::G.CreateTextToImageRequestGen4ImageReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentModeration")]
        public global::G.CreateTextToImageRequestGen4ImageContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gen4_image"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "gen4_image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4Image" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to three images to be used as references for the generated image output.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="model"></param>
        public CreateTextToImageRequestGen4Image(
            string promptText,
            global::G.CreateTextToImageRequestGen4ImageRatio ratio,
            int? seed,
            global::System.Collections.Generic.IList<global::G.CreateTextToImageRequestGen4ImageReferenceImage>? referenceImages,
            global::G.CreateTextToImageRequestGen4ImageContentModeration? contentModeration,
            string model = "gen4_image")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Seed = seed;
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4Image" /> class.
        /// </summary>
        public CreateTextToImageRequestGen4Image()
        {
        }
    }
}