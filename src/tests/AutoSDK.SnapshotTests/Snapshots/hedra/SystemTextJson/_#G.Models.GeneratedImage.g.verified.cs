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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Width of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Inputs for generating the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedImageInputs GeneratedImageInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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