//HintName: G.Models.ConversationItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A realtime conversation item.
    /// </summary>
    public sealed partial class ConversationItem
    {
        /// <summary>
        /// The unique ID of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemObjectJsonConverter))]
        public global::G.ConversationItemObject? Object { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemTypeJsonConverter))]
        public global::G.ConversationItemType? Type { get; set; }

        /// <summary>
        /// The status of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemStatusJsonConverter))]
        public global::G.ConversationItemStatus? Status { get; set; }

        /// <summary>
        /// The role of the message sender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemRoleJsonConverter))]
        public global::G.ConversationItemRole? Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ConversationItemContentPart>? Content { get; set; }

        /// <summary>
        /// The ID of the function call (for function_call items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The name of the function being called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The arguments of the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The output of the function call (for function_call_output items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the item.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="type">
        /// The type of the item.
        /// </param>
        /// <param name="status">
        /// The status of the item.
        /// </param>
        /// <param name="role">
        /// The role of the message sender.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call (for function_call items).
        /// </param>
        /// <param name="name">
        /// The name of the function being called.
        /// </param>
        /// <param name="arguments">
        /// The arguments of the function call.
        /// </param>
        /// <param name="output">
        /// The output of the function call (for function_call_output items).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItem(
            string? id,
            global::G.ConversationItemObject? @object,
            global::G.ConversationItemType? type,
            global::G.ConversationItemStatus? status,
            global::G.ConversationItemRole? role,
            global::System.Collections.Generic.IList<global::G.ConversationItemContentPart>? content,
            string? callId,
            string? name,
            string? arguments,
            string? output)
        {
            this.Id = id;
            this.Object = @object;
            this.Type = type;
            this.Status = status;
            this.Role = role;
            this.Content = content;
            this.CallId = callId;
            this.Name = name;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItem" /> class.
        /// </summary>
        public ConversationItem()
        {
        }
    }
}