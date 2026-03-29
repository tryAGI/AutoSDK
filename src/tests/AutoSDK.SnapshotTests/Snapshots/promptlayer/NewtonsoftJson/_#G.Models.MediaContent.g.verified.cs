//HintName: G.Models.MediaContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaContent
    {
        /// <summary>
        /// Default Value: media
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MediaContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Media Media { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContent" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="type">
        /// Default Value: media
        /// </param>
        public MediaContent(
            global::G.Media media,
            global::G.MediaContentType? type)
        {
            this.Type = type;
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContent" /> class.
        /// </summary>
        public MediaContent()
        {
        }
    }
}