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
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Image1 { get; set; }

        /// <summary>
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: Qdrant/clip-ViT-B-32-vision
        /// </summary>
        /// <example>Qdrant/clip-ViT-B-32-vision</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Parameters for the model Values of the parameters are model-specific
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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