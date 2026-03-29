//HintName: G.Models.RetrieveStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveStreamRequest
    {
        /// <summary>
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Sequence id to use as a cursor for pagination. Response will start streaming after this chunk sequence id<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_after")]
        public int? StartingAfter { get; set; }

        /// <summary>
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_pings")]
        public bool? IncludePings { get; set; }

        /// <summary>
        /// Seconds to wait between polls when no new data.<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_interval")]
        public double? PollInterval { get; set; }

        /// <summary>
        /// Number of entries to read per batch.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveStreamRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="startingAfter">
        /// Sequence id to use as a cursor for pagination. Response will start streaming after this chunk sequence id<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="pollInterval">
        /// Seconds to wait between polls when no new data.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="batchSize">
        /// Number of entries to read per batch.<br/>
        /// Default Value: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveStreamRequest(
            string? agentId,
            int? startingAfter,
            bool? includePings,
            double? pollInterval,
            int? batchSize)
        {
            this.AgentId = agentId;
            this.StartingAfter = startingAfter;
            this.IncludePings = includePings;
            this.PollInterval = pollInterval;
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveStreamRequest" /> class.
        /// </summary>
        public RetrieveStreamRequest()
        {
        }
    }
}