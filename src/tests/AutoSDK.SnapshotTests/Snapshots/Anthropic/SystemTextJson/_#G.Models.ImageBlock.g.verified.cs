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
        public string? Type { get; set; } = "image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}