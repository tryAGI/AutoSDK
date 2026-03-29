//HintName: G.Models.ActiveCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActiveCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective")]
        public string? Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("international")]
        public string? International { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActiveCallStatusJsonConverter))]
        public global::G.ActiveCallStatus? Status { get; set; }

        /// <summary>
        /// Unix epoch in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveCall" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="userId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="objective"></param>
        /// <param name="pathwayId"></param>
        /// <param name="startTime"></param>
        /// <param name="international"></param>
        /// <param name="status"></param>
        /// <param name="timestamp">
        /// Unix epoch in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveCall(
            string? callId,
            string? userId,
            string? from,
            string? to,
            string? objective,
            string? pathwayId,
            global::System.DateTime? startTime,
            string? international,
            global::G.ActiveCallStatus? status,
            string? timestamp)
        {
            this.CallId = callId;
            this.UserId = userId;
            this.From = from;
            this.To = to;
            this.Objective = objective;
            this.PathwayId = pathwayId;
            this.StartTime = startTime;
            this.International = international;
            this.Status = status;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveCall" /> class.
        /// </summary>
        public ActiveCall()
        {
        }
    }
}