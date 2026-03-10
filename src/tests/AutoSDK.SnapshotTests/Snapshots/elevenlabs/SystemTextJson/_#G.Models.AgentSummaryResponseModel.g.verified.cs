//HintName: G.Models.AgentSummaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"access_info":{"creator_email":"john@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"},"agent_id":"J3Pbu5gP6NNKBscdCdwB","archived":false,"created_at_unix_secs":1716153600,"last_call_time_unix_secs":1716240000,"name":"My Agent","tags":["Customer Support","Technical Help","Eleven"]}
    /// </summary>
    public sealed partial class AgentSummaryResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Agent tags used to categorize the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// The creation time of the agent in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// The access information of the agent<br/>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// The time of the most recent call in unix seconds, null if no calls have been made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_call_time_unix_secs")]
        public int? LastCallTimeUnixSecs { get; set; }

        /// <summary>
        /// Whether the agent is archived<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="name">
        /// The name of the agent
        /// </param>
        /// <param name="tags">
        /// Agent tags used to categorize the agent
        /// </param>
        /// <param name="createdAtUnixSecs">
        /// The creation time of the agent in unix seconds
        /// </param>
        /// <param name="accessInfo">
        /// The access information of the agent<br/>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="lastCallTimeUnixSecs">
        /// The time of the most recent call in unix seconds, null if no calls have been made
        /// </param>
        /// <param name="archived">
        /// Whether the agent is archived<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSummaryResponseModel(
            string agentId,
            string name,
            global::System.Collections.Generic.IList<string> tags,
            int createdAtUnixSecs,
            global::G.ResourceAccessInfo accessInfo,
            int? lastCallTimeUnixSecs,
            bool? archived)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.LastCallTimeUnixSecs = lastCallTimeUnixSecs;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryResponseModel" /> class.
        /// </summary>
        public AgentSummaryResponseModel()
        {
        }
    }
}