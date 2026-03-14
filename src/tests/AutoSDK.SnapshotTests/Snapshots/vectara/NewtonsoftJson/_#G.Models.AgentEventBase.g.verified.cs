//HintName: G.Models.AgentEventBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base properties shared by all agent event types.
    /// </summary>
    public sealed partial class AgentEventBase
    {
        /// <summary>
        /// The unique identifier for the event.<br/>
        /// Example: aev_user_001
        /// </summary>
        /// <example>aev_user_001</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::Newtonsoft.Json.JsonProperty("session_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionKey { get; set; } = default!;

        /// <summary>
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEventBase" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the event.<br/>
        /// Example: aev_user_001
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        public AgentEventBase(
            string id,
            string sessionKey,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEventBase" /> class.
        /// </summary>
        public AgentEventBase()
        {
        }
    }
}