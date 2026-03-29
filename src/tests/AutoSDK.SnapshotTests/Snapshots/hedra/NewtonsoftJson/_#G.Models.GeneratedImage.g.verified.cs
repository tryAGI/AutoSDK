//HintName: G.Models.GeneratedImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedImage
    {
        /// <summary>
        /// Default Value: generated_image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Width of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Height of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// URL of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Inputs for generating the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_image_inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeneratedImageInputs GeneratedImageInputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the image.
        /// </param>
        /// <param name="height">
        /// Height of the image.
        /// </param>
        /// <param name="url">
        /// URL of the image.
        /// </param>
        /// <param name="generatedImageInputs">
        /// Inputs for generating the image.
        /// </param>
        /// <param name="type">
        /// Default Value: generated_image
        /// </param>
        public GeneratedImage(
            int width,
            int height,
            string url,
            global::G.GeneratedImageInputs generatedImageInputs,
            string? type)
        {
            this.Type = type;
            this.Width = width;
            this.Height = height;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GeneratedImageInputs = generatedImageInputs ?? throw new global::System.ArgumentNullException(nameof(generatedImageInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        public GeneratedImage()
        {
        }
    }
}