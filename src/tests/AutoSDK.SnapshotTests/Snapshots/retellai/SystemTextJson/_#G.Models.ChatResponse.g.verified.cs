//HintName: G.Models.ChatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponse
    {
        /// <summary>
        /// Unique id of the chat.<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// Corresponding chat agent id of this chat.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The version of the agent<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </summary>
        /// <example>{"customer_name":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retell_llm_dynamic_variables")]
        public object? RetellLlmDynamicVariables { get; set; }

        /// <summary>
        /// Dynamic variables collected from the chat. Only available after the chat ends.<br/>
        /// Example: {"last_node_name":"Test node"}
        /// </summary>
        /// <example>{"last_node_name":"Test node"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collected_dynamic_variables")]
        public object? CollectedDynamicVariables { get; set; }

        /// <summary>
        /// Status of chat.<br/>
        /// - `ongoing`: Chat session is ongoing, chat agent can receive new message and generate response.<br/>
        /// - `ended`: Chat session has ended, and no longer can generate new response.<br/>
        /// - `error`: Chat encountered error.<br/>
        /// Example: ongoing
        /// </summary>
        /// <example>ongoing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatResponseChatStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatResponseChatStatus ChatStatus { get; set; }

        /// <summary>
        /// Type of the chat<br/>
        /// Example: api_chat
        /// </summary>
        /// <example>api_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatResponseChatTypeJsonConverter))]
        public global::G.ChatResponseChatType? ChatType { get; set; }

        /// <summary>
        /// Custom attributes for the chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attributes")]
        public object? CustomAttributes { get; set; }

        /// <summary>
        /// Begin timestamp (milliseconds since epoch) of the chat. Available after chat starts.<br/>
        /// Example: 1703302407333
        /// </summary>
        /// <example>1703302407333</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// End timestamp (milliseconds since epoch) of the chat. Available after chat ends.<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// Transcription of the chat.<br/>
        /// Example: Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </summary>
        /// <example>
        /// Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Transcript of the chat weaved with tool call invocation and results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_with_tool_calls")]
        public global::System.Collections.Generic.IList<global::G.MessageOrToolCall>? MessageWithToolCalls { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_cost")]
        public global::G.ChatResponseChatCost? ChatCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_analysis")]
        public global::G.ChatAnalysis? ChatAnalysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        /// <param name="chatId">
        /// Unique id of the chat.<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="agentId">
        /// Corresponding chat agent id of this chat.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="chatStatus">
        /// Status of chat.<br/>
        /// - `ongoing`: Chat session is ongoing, chat agent can receive new message and generate response.<br/>
        /// - `ended`: Chat session has ended, and no longer can generate new response.<br/>
        /// - `error`: Chat encountered error.<br/>
        /// Example: ongoing
        /// </param>
        /// <param name="version">
        /// The version of the agent<br/>
        /// Example: 1
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="collectedDynamicVariables">
        /// Dynamic variables collected from the chat. Only available after the chat ends.<br/>
        /// Example: {"last_node_name":"Test node"}
        /// </param>
        /// <param name="chatType">
        /// Type of the chat<br/>
        /// Example: api_chat
        /// </param>
        /// <param name="customAttributes">
        /// Custom attributes for the chat
        /// </param>
        /// <param name="startTimestamp">
        /// Begin timestamp (milliseconds since epoch) of the chat. Available after chat starts.<br/>
        /// Example: 1703302407333
        /// </param>
        /// <param name="endTimestamp">
        /// End timestamp (milliseconds since epoch) of the chat. Available after chat ends.<br/>
        /// Example: 1703302428855
        /// </param>
        /// <param name="transcript">
        /// Transcription of the chat.<br/>
        /// Example: Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </param>
        /// <param name="messageWithToolCalls">
        /// Transcript of the chat weaved with tool call invocation and results.
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object.
        /// </param>
        /// <param name="chatCost"></param>
        /// <param name="chatAnalysis"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatResponse(
            string chatId,
            string agentId,
            global::G.ChatResponseChatStatus chatStatus,
            int? version,
            object? retellLlmDynamicVariables,
            object? collectedDynamicVariables,
            global::G.ChatResponseChatType? chatType,
            object? customAttributes,
            long? startTimestamp,
            long? endTimestamp,
            string? transcript,
            global::System.Collections.Generic.IList<global::G.MessageOrToolCall>? messageWithToolCalls,
            object? metadata,
            global::G.ChatResponseChatCost? chatCost,
            global::G.ChatAnalysis? chatAnalysis)
        {
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
            this.CollectedDynamicVariables = collectedDynamicVariables;
            this.ChatStatus = chatStatus;
            this.ChatType = chatType;
            this.CustomAttributes = customAttributes;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.Transcript = transcript;
            this.MessageWithToolCalls = messageWithToolCalls;
            this.Metadata = metadata;
            this.ChatCost = chatCost;
            this.ChatAnalysis = chatAnalysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        public ChatResponse()
        {
        }
    }
}