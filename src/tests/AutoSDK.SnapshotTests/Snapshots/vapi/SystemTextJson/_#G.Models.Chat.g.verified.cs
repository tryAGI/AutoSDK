//HintName: G.Models.Chat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is the name of the chat. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>))]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>? Input { get; set; }

        /// <summary>
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousChatId")]
        public string? PreviousChatId { get; set; }

        /// <summary>
        /// This is the unique identifier for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this chat belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is an array of messages used as context for the chat.<br/>
        /// Used to provide message history for multi-turn conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the output messages generated by the system in response to the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? Output { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the chat was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the chat was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// These are the costs of individual components of the chat in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costs")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ModelCost, global::G.ChatCost>>? Costs { get; set; }

        /// <summary>
        /// This is the cost of the chat in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the chat.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this chat belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the chat was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the chat was last updated.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </param>
        /// <param name="squad">
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </param>
        /// <param name="name">
        /// This is the name of the chat. This is just for your own reference.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </param>
        /// <param name="input">
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.
        /// </param>
        /// <param name="stream">
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="previousChatId">
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </param>
        /// <param name="messages">
        /// This is an array of messages used as context for the chat.<br/>
        /// Used to provide message history for multi-turn conversations.
        /// </param>
        /// <param name="output">
        /// This is the output messages generated by the system in response to the input.
        /// </param>
        /// <param name="costs">
        /// These are the costs of individual components of the chat in USD.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the chat in USD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chat(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            string? name,
            string? sessionId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>? input,
            bool? stream,
            string? previousChatId,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? output,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ModelCost, global::G.ChatCost>>? costs,
            double? cost)
        {
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.Name = name;
            this.SessionId = sessionId;
            this.Input = input;
            this.Stream = stream;
            this.PreviousChatId = previousChatId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Messages = messages;
            this.Output = output;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Costs = costs;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        public Chat()
        {
        }
    }
}