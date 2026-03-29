//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WARN: Work-in-progress, unimplemented<br/>
    /// Image object for embedding. Requires inference infrastructure, unimplemented.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Image data: base64 encoded image or an URL<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public object Image1 { get; set; } = default!;

        /// <summary>
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: Qdrant/clip-ViT-B-32-vision
        /// </summary>
        /// <example>Qdrant/clip-ViT-B-32-vision</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Parameters for the model Values of the parameters are model-specific
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="image1">
        /// Image data: base64 encoded image or an URL<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="model">
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: Qdrant/clip-ViT-B-32-vision
        /// </param>
        /// <param name="options">
        /// Parameters for the model Values of the parameters are model-specific
        /// </param>
        public Image(
            object image1,
            string model,
            object? options)
        {
            this.Image1 = image1 ?? throw new global::System.ArgumentNullException(nameof(image1));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}