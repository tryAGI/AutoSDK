//HintName: G.Models.StateTransitionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateTransitionMessage
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// This is a state transition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StateTransitionMessageRoleJsonConverter))]
        public global::G.StateTransitionMessageRole Role { get; set; }

        /// <summary>
        /// Former state name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("former_state_name")]
        public string? FormerStateName { get; set; }

        /// <summary>
        /// New state name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_state_name")]
        public string? NewStateName { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long CreatedTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateTransitionMessage" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
        /// <param name="role">
        /// This is a state transition.
        /// </param>
        /// <param name="formerStateName">
        /// Former state name
        /// </param>
        /// <param name="newStateName">
        /// New state name
        /// </param>
        public StateTransitionMessage(
            string messageId,
            long createdTimestamp,
            global::G.StateTransitionMessageRole role,
            string? formerStateName,
            string? newStateName)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Role = role;
            this.FormerStateName = formerStateName;
            this.NewStateName = newStateName;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateTransitionMessage" /> class.
        /// </summary>
        public StateTransitionMessage()
        {
        }
    }
}