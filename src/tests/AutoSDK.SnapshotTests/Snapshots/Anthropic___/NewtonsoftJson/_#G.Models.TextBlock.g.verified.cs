//HintName: G.Models.TextBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A block of text content.
    /// </summary>
    public sealed partial class TextBlock
    {
        /// <summary>
        /// The text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: text
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
        /// Initializes a new instance of the <see cref="TextBlock" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        public TextBlock(
            string text,
            string? type,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBlock" /> class.
        /// </summary>
        public TextBlock()
        {
        }
    }
}