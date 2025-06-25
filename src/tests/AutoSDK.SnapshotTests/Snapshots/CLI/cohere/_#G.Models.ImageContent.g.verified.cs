﻿//HintName: G.Models.ImageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image content of the message.
    /// </summary>
    public sealed partial class ImageContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Type of message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Type of message content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageContent(
            global::G.ImageUrl imageUrl,
            global::G.ContentType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        public ImageContent()
        {
        }
    }
}