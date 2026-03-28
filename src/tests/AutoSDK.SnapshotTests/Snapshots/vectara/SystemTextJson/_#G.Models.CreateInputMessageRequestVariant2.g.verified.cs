//HintName: G.Models.CreateInputMessageRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInputMessageRequestVariant2
    {
        /// <summary>
        /// Default Value: input_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of inputs that make up this event.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </summary>
        /// <example>[{"type":"text","content":"I need help with my widget installation"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentInput> Messages { get; set; }

        /// <summary>
        /// Event ID to return all events created after queueing the new input. When provided and the session is currently running, the response will include all events created after this event ID, and the new input will be processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </summary>
        /// <example>start</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        public string? Since { get; set; }

        /// <summary>
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputBehaviorJsonConverter))]
        public global::G.InputBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputMessageRequestVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of inputs that make up this event.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </param>
        /// <param name="type">
        /// Default Value: input_message
        /// </param>
        /// <param name="since">
        /// Event ID to return all events created after queueing the new input. When provided and the session is currently running, the response will include all events created after this event ID, and the new input will be processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </param>
        /// <param name="behavior">
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInputMessageRequestVariant2(
            global::System.Collections.Generic.IList<global::G.AgentInput> messages,
            string? type,
            string? since,
            global::G.InputBehavior? behavior)
        {
            this.Type = type;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Since = since;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputMessageRequestVariant2" /> class.
        /// </summary>
        public CreateInputMessageRequestVariant2()
        {
        }
    }
}