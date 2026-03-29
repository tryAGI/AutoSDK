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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Event classification (e.g. "lifecycle", "complete")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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