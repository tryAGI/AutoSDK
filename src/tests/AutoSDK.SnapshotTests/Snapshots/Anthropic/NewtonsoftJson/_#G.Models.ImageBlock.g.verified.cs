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
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageBlockSource Source { get; set; } = default!;

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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