//HintName: G.Models.TextToImageAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The TextToImageAsset lets you create a dynamic image from a text prompt.
    /// </summary>
    public sealed partial class TextToImageAsset
    {
        /// <summary>
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </summary>
        /// <default>global::G.TextToImageAssetType.TextToImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToImageAssetTypeJsonConverter))]
        public global::G.TextToImageAssetType Type { get; set; } = global::G.TextToImageAssetType.TextToImage;

        /// <summary>
        /// The text prompt to generate an image from.<br/>
        /// Example: A serene landscape featuring a crystal-clear mountain lake at sunrise. The water reflects the pink and orange sky like a mirror. In the foreground, a majestic pine tree stands tall, its branches framing the view. Snow-capped peaks rise in the distance, their edges softened by a light morning mist. A pair of deer drink from the lake's edge, creating gentle ripples on the otherwise still surface.
        /// </summary>
        /// <example>A serene landscape featuring a crystal-clear mountain lake at sunrise. The water reflects the pink and orange sky like a mirror. In the foreground, a majestic pine tree stands tall, its branches framing the view. Snow-capped peaks rise in the distance, their edges softened by a light morning mist. A pair of deer drink from the lake's edge, creating gentle ripples on the otherwise still surface.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The width of the image in pixels.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the image in pixels.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        public global::G.Crop? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageAsset" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt to generate an image from.<br/>
        /// Example: A serene landscape featuring a crystal-clear mountain lake at sunrise. The water reflects the pink and orange sky like a mirror. In the foreground, a majestic pine tree stands tall, its branches framing the view. Snow-capped peaks rise in the distance, their edges softened by a light morning mist. A pair of deer drink from the lake's edge, creating gentle ripples on the otherwise still surface.
        /// </param>
        /// <param name="width">
        /// The width of the image in pixels.<br/>
        /// Example: 512
        /// </param>
        /// <param name="height">
        /// The height of the image in pixels.<br/>
        /// Example: 512
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageAsset(
            string prompt,
            int? width,
            int? height,
            global::G.Crop? crop,
            global::G.TextToImageAssetType type = global::G.TextToImageAssetType.TextToImage)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageAsset" /> class.
        /// </summary>
        public TextToImageAsset()
        {
        }
    }
}