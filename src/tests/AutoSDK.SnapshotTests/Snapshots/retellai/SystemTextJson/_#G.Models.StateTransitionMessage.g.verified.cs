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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// This is a state transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StateTransitionMessageRoleJsonConverter))]
        public global::G.StateTransitionMessageRole Role { get; set; }

        /// <summary>
        /// Former state name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("former_state_name")]
        public string? FormerStateName { get; set; }

        /// <summary>
        /// New state name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_state_name")]
        public string? NewStateName { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreatedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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