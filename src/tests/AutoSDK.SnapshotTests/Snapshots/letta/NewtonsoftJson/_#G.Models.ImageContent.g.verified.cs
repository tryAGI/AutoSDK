//HintName: G.Models.ImageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageContent
    {
        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The source of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of the image.
        /// </param>
        /// <param name="type">
        /// The type of the message.<br/>
        /// Default Value: image
        /// </param>
        public ImageContent(
            global::G.Source source,
            string? type)
        {
            this.Type = type;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        public ImageContent()
        {
        }
    }
}