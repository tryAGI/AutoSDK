//HintName: G.Models.MessageDeltaObjectDelta.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The delta containing the fields that have changed on the Message.
    /// </summary>
    public sealed partial class MessageDeltaObjectDelta
    {
        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentImageFileObject, global::G.MessageDeltaContentTextObject, global::G.MessageDeltaContentRefusalObject, global::G.MessageDeltaContentImageUrlObject>>? Content { get; set; }

        /// <summary>
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter))]
        public global::G.MessageDeltaObjectDeltaRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObjectDelta" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message in array of text and/or images.
        /// </param>
        /// <param name="role">
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaObjectDelta(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentImageFileObject, global::G.MessageDeltaContentTextObject, global::G.MessageDeltaContentRefusalObject, global::G.MessageDeltaContentImageUrlObject>>? content,
            global::G.MessageDeltaObjectDeltaRole? role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObjectDelta" /> class.
        /// </summary>
        public MessageDeltaObjectDelta()
        {
        }
    }
}