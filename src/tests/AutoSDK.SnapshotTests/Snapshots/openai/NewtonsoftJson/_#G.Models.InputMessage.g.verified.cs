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
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputContent> Content { get; set; } = default!;

        /// <summary>
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputMessageRole Role { get; set; } = default!;

        /// <summary>
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.InputMessageStatus? Status { get; set; }

        /// <summary>
        /// The type of the message input. Always set to `message`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </param>
        /// <param name="role">
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </param>
        /// <param name="status">
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the message input. Always set to `message`.
        /// </param>
        public InputMessage(
            global::System.Collections.Generic.IList<global::G.InputContent> content,
            global::G.InputMessageRole role,
            global::G.InputMessageStatus? status,
            global::G.InputMessageType? type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        public InputMessage()
        {
        }
    }
}