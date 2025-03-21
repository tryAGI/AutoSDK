//HintName: G.Models.InputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message input to the model with a role indicating instruction following<br/>
    /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
    /// precedence over instructions given with the `user` role.
    /// </summary>
    public sealed partial class InputMessage
    {
        /// <summary>
        /// The type of the message input. Always set to `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputMessageTypeJsonConverter))]
        public global::G.InputMessageType? Type { get; set; }

        /// <summary>
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InputMessageRole Role { get; set; }

        /// <summary>
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputMessageStatusJsonConverter))]
        public global::G.InputMessageStatus? Status { get; set; }

        /// <summary>
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InputContent> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the message input. Always set to `message`.
        /// </param>
        /// <param name="role">
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </param>
        /// <param name="status">
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="content">
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessage(
            global::G.InputMessageRole role,
            global::System.Collections.Generic.IList<global::G.InputContent> content,
            global::G.InputMessageType? type,
            global::G.InputMessageStatus? status)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        public InputMessage()
        {
        }
    }
}