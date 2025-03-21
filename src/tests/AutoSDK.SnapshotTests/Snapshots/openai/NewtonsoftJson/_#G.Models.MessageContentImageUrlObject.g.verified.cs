//HintName: G.Models.MessageContentImageUrlObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// References an image URL in the content of a message.
    /// </summary>
    public sealed partial class MessageContentImageUrlObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageContentImageUrlObjectImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageContentImageUrlObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageUrlObject" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        public MessageContentImageUrlObject(
            global::G.MessageContentImageUrlObjectImageUrl imageUrl,
            global::G.MessageContentImageUrlObjectType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageUrlObject" /> class.
        /// </summary>
        public MessageContentImageUrlObject()
        {
        }
    }
}