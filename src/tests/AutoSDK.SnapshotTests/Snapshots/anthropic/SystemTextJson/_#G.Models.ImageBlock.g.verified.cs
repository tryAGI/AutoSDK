//HintName: G.Models.ImageBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A block of image content.
    /// </summary>
    public sealed partial class ImageBlock
    {
        /// <summary>
        /// The source of an image block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageBlockSource Source { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlock" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of an image block.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: image
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageBlock(
            global::G.ImageBlockSource source,
            string? type,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlock" /> class.
        /// </summary>
        public ImageBlock()
        {
        }
    }
}