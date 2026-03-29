//HintName: G.Models.CallSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Duration in minutes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_length")]
        public float? CallLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public string? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_status")]
        public string? QueueStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answered_by")]
        public string? AnsweredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSummary" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="createdAt"></param>
        /// <param name="callLength">
        /// Duration in minutes
        /// </param>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="completed"></param>
        /// <param name="queueStatus"></param>
        /// <param name="errorMessage"></param>
        /// <param name="answeredBy"></param>
        /// <param name="batchId"></param>
        public CallSummary(
            string? callId,
            global::System.DateTime? createdAt,
            float? callLength,
            string? to,
            string? from,
            bool? completed,
            string? queueStatus,
            string? errorMessage,
            string? answeredBy,
            string? batchId)
        {
            this.CallId = callId;
            this.CreatedAt = createdAt;
            this.CallLength = callLength;
            this.To = to;
            this.From = from;
            this.Completed = completed;
            this.QueueStatus = queueStatus;
            this.ErrorMessage = errorMessage;
            this.AnsweredBy = answeredBy;
            this.BatchId = batchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSummary" /> class.
        /// </summary>
        public CallSummary()
        {
        }
    }
}