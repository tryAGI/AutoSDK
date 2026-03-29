//HintName: G.Models.BatchCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchCallResponse
    {
        /// <summary>
        /// Unique id of the batch call.<br/>
        /// Example: batch_call_dbcc4412483ebfc348abb
        /// </summary>
        /// <example>batch_call_dbcc4412483ebfc348abb</example>
        [global::Newtonsoft.Json.JsonProperty("batch_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BatchCallId { get; set; } = default!;

        /// <summary>
        /// Example: First batch call
        /// </summary>
        /// <example>First batch call</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::Newtonsoft.Json.JsonProperty("from_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromNumber { get; set; } = default!;

        /// <summary>
        /// Example: 1735718400
        /// </summary>
        /// <example>1735718400</example>
        [global::Newtonsoft.Json.JsonProperty("scheduled_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScheduledTimestamp { get; set; } = default!;

        /// <summary>
        /// Number of tasks within the batch call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_task_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTaskCount { get; set; } = default!;

        /// <summary>
        /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_time_window")]
        public global::G.CallTimeWindow? CallTimeWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallResponse" /> class.
        /// </summary>
        /// <param name="batchCallId">
        /// Unique id of the batch call.<br/>
        /// Example: batch_call_dbcc4412483ebfc348abb
        /// </param>
        /// <param name="name">
        /// Example: First batch call
        /// </param>
        /// <param name="fromNumber">
        /// Example: +14157774444
        /// </param>
        /// <param name="scheduledTimestamp">
        /// Example: 1735718400
        /// </param>
        /// <param name="totalTaskCount">
        /// Number of tasks within the batch call
        /// </param>
        /// <param name="callTimeWindow">
        /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
        /// </param>
        public BatchCallResponse(
            string batchCallId,
            string name,
            string fromNumber,
            double scheduledTimestamp,
            double totalTaskCount,
            global::G.CallTimeWindow? callTimeWindow)
        {
            this.BatchCallId = batchCallId ?? throw new global::System.ArgumentNullException(nameof(batchCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ScheduledTimestamp = scheduledTimestamp;
            this.TotalTaskCount = totalTaskCount;
            this.CallTimeWindow = callTimeWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallResponse" /> class.
        /// </summary>
        public BatchCallResponse()
        {
        }
    }
}