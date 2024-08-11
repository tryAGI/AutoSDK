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
        public string? Type { get; set; } = "image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}