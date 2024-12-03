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
        /// The type of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter))]
        public global::G.MessageContentImageUrlObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageContentImageUrlObjectImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageUrlObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        /// <param name="imageUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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