//HintName: G.Models.BatchLogEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Event classification (e.g. "lifecycle", "complete")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLogEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="batchId"></param>
        /// <param name="orgId"></param>
        /// <param name="eventType">
        /// Event classification (e.g. "lifecycle", "complete")
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchLogEntry(
            string? id,
            string? batchId,
            string? orgId,
            string? eventType,
            global::System.DateTime? timestamp,
            object? payload)
        {
            this.Id = id;
            this.BatchId = batchId;
            this.OrgId = orgId;
            this.EventType = eventType;
            this.Timestamp = timestamp;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLogEntry" /> class.
        /// </summary>
        public BatchLogEntry()
        {
        }
    }
}