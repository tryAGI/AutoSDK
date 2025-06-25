//HintName: G.Models.RealtimeConversationItemWithReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The item to add to the conversation.
    /// </summary>
    public sealed partial class RealtimeConversationItemWithReference
    {
        /// <summary>
        /// For an item of type (`message` | `function_call` | `function_call_output`)<br/>
        /// this field allows the client to assign the unique ID of the item. It is<br/>
        /// not required because the server will generate one if not provided.<br/>
        /// For an item of type `item_reference`, this field is required and is a<br/>
        /// reference to any item that has previously existed in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of the item (`message`, `function_call`, `function_call_output`, `item_reference`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeConversationItemWithReferenceTypeJsonConverter))]
        public global::G.RealtimeConversationItemWithReferenceType? Type { get; set; }

        /// <summary>
        /// Identifier for the API object being returned - always `realtime.item`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeConversationItemWithReferenceObjectJsonConverter))]
        public global::G.RealtimeConversationItemWithReferenceObject? Object { get; set; }

        /// <summary>
        /// The status of the item (`completed`, `incomplete`). These have no effect <br/>
        /// on the conversation, but are accepted for consistency with the <br/>
        /// `conversation.item.created` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeConversationItemWithReferenceStatusJsonConverter))]
        public global::G.RealtimeConversationItemWithReferenceStatus? Status { get; set; }

        /// <summary>
        /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
        /// applicable for `message` items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeConversationItemWithReferenceRoleJsonConverter))]
        public global::G.RealtimeConversationItemWithReferenceRole? Role { get; set; }

        /// <summary>
        /// The content of the message, applicable for `message` items. <br/>
        /// - Message items of role `system` support only `input_text` content<br/>
        /// - Message items of role `user` support `input_text` and `input_audio` <br/>
        ///   content<br/>
        /// - Message items of role `assistant` support `text` content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.RealtimeConversationItemWithReferenceContentItem>? Content { get; set; }

        /// <summary>
        /// The ID of the function call (for `function_call` and <br/>
        /// `function_call_output` items). If passed on a `function_call_output` <br/>
        /// item, the server will check that a `function_call` item with the same <br/>
        /// ID exists in the conversation history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The name of the function being called (for `function_call` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The arguments of the function call (for `function_call` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The output of the function call (for `function_call_output` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReference" /> class.
        /// </summary>
        /// <param name="id">
        /// For an item of type (`message` | `function_call` | `function_call_output`)<br/>
        /// this field allows the client to assign the unique ID of the item. It is<br/>
        /// not required because the server will generate one if not provided.<br/>
        /// For an item of type `item_reference`, this field is required and is a<br/>
        /// reference to any item that has previously existed in the conversation.
        /// </param>
        /// <param name="type">
        /// The type of the item (`message`, `function_call`, `function_call_output`, `item_reference`).
        /// </param>
        /// <param name="object">
        /// Identifier for the API object being returned - always `realtime.item`.
        /// </param>
        /// <param name="status">
        /// The status of the item (`completed`, `incomplete`). These have no effect <br/>
        /// on the conversation, but are accepted for consistency with the <br/>
        /// `conversation.item.created` event.
        /// </param>
        /// <param name="role">
        /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
        /// applicable for `message` items.
        /// </param>
        /// <param name="content">
        /// The content of the message, applicable for `message` items. <br/>
        /// - Message items of role `system` support only `input_text` content<br/>
        /// - Message items of role `user` support `input_text` and `input_audio` <br/>
        ///   content<br/>
        /// - Message items of role `assistant` support `text` content.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call (for `function_call` and <br/>
        /// `function_call_output` items). If passed on a `function_call_output` <br/>
        /// item, the server will check that a `function_call` item with the same <br/>
        /// ID exists in the conversation history.
        /// </param>
        /// <param name="name">
        /// The name of the function being called (for `function_call` items).
        /// </param>
        /// <param name="arguments">
        /// The arguments of the function call (for `function_call` items).
        /// </param>
        /// <param name="output">
        /// The output of the function call (for `function_call_output` items).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemWithReference(
            string? id,
            global::G.RealtimeConversationItemWithReferenceType? type,
            global::G.RealtimeConversationItemWithReferenceObject? @object,
            global::G.RealtimeConversationItemWithReferenceStatus? status,
            global::G.RealtimeConversationItemWithReferenceRole? role,
            global::System.Collections.Generic.IList<global::G.RealtimeConversationItemWithReferenceContentItem>? content,
            string? callId,
            string? name,
            string? arguments,
            string? output)
        {
            this.Id = id;
            this.Type = type;
            this.Object = @object;
            this.Status = status;
            this.Role = role;
            this.Content = content;
            this.CallId = callId;
            this.Name = name;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReference" /> class.
        /// </summary>
        public RealtimeConversationItemWithReference()
        {
        }
    }
}