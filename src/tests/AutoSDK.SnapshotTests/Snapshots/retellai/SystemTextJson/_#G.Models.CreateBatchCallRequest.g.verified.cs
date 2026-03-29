//HintName: G.Models.CreateBatchCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchCallRequest
    {
        /// <summary>
        /// The name of the batch call. Only used for your own reference.<br/>
        /// Example: First batch call
        /// </summary>
        /// <example>First batch call</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The scheduled time for sending the batch call, represented as a Unix timestamp in milliseconds. If omitted, the call will be sent immediately.<br/>
        /// Example: 1735718400000
        /// </summary>
        /// <example>1735718400000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_timestamp")]
        public double? TriggerTimestamp { get; set; }

        /// <summary>
        /// The number you own in E.164 format. Must be a number purchased from Retell or imported to Retell.<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromNumber { get; set; }

        /// <summary>
        /// Number of concurrency reserved for all other calls that are not triggered by batch calls, such as inbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_concurrency")]
        public int? ReservedConcurrency { get; set; }

        /// <summary>
        /// A list of individual call tasks to be executed as part of the batch call. Each task represents a single outbound call and includes details such as the recipient's phone number and optional dynamic variables to personalize the call content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BatchCallTask> Tasks { get; set; }

        /// <summary>
        /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_time_window")]
        public global::G.CallTimeWindow? CallTimeWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchCallRequest" /> class.
        /// </summary>
        /// <param name="fromNumber">
        /// The number you own in E.164 format. Must be a number purchased from Retell or imported to Retell.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="tasks">
        /// A list of individual call tasks to be executed as part of the batch call. Each task represents a single outbound call and includes details such as the recipient's phone number and optional dynamic variables to personalize the call content.
        /// </param>
        /// <param name="name">
        /// The name of the batch call. Only used for your own reference.<br/>
        /// Example: First batch call
        /// </param>
        /// <param name="triggerTimestamp">
        /// The scheduled time for sending the batch call, represented as a Unix timestamp in milliseconds. If omitted, the call will be sent immediately.<br/>
        /// Example: 1735718400000
        /// </param>
        /// <param name="reservedConcurrency">
        /// Number of concurrency reserved for all other calls that are not triggered by batch calls, such as inbound calls.
        /// </param>
        /// <param name="callTimeWindow">
        /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchCallRequest(
            string fromNumber,
            global::System.Collections.Generic.IList<global::G.BatchCallTask> tasks,
            string? name,
            double? triggerTimestamp,
            int? reservedConcurrency,
            global::G.CallTimeWindow? callTimeWindow)
        {
            this.Name = name;
            this.TriggerTimestamp = triggerTimestamp;
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ReservedConcurrency = reservedConcurrency;
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.CallTimeWindow = callTimeWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchCallRequest" /> class.
        /// </summary>
        public CreateBatchCallRequest()
        {
        }
    }
}