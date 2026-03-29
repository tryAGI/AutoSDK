//HintName: G.Models.ShotstackTextToImageOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the Shotstack text-to-image service. Set a text prompt to generate an image from. The output will be  generated as a PNG file available at the URL returned in the response.
    /// </summary>
    public sealed partial class ShotstackTextToImageOptions
    {
        /// <summary>
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </summary>
        /// <default>global::G.ShotstackTextToImageOptionsType.TextToImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShotstackTextToImageOptionsTypeJsonConverter))]
        public global::G.ShotstackTextToImageOptionsType Type { get; set; } = global::G.ShotstackTextToImageOptionsType.TextToImage;

        /// <summary>
        /// The text prompt to generate an image from.<br/>
        /// Example: A detailed photograph of Mars, showcasing its orange-red surface
        /// </summary>
        /// <example>A detailed photograph of Mars, showcasing its orange-red surface</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The width of the image in pixels.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The height of the image in pixels.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackTextToImageOptions" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt to generate an image from.<br/>
        /// Example: A detailed photograph of Mars, showcasing its orange-red surface
        /// </param>
        /// <param name="width">
        /// The width of the image in pixels.<br/>
        /// Example: 512
        /// </param>
        /// <param name="height">
        /// The height of the image in pixels.<br/>
        /// Example: 512
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShotstackTextToImageOptions(
            string prompt,
            int width,
            int height,
            global::G.ShotstackTextToImageOptionsType type = global::G.ShotstackTextToImageOptionsType.TextToImage)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackTextToImageOptions" /> class.
        /// </summary>
        public ShotstackTextToImageOptions()
        {
        }
    }
}