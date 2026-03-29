//HintName: G.Models.ListCallsRequestFilterCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter criteria for the calls to retrieve.<br/>
    /// Example: {"call_id":["call_5a82f0a43ea0977566b1104fcfc"],"agent_id":["agent_oBeDLoLOeuAbiuaMFXRtDOLriT12345"],"call_status":["ended"],"call_type":["phone_call"],"direction":["inbound"],"user_sentiment":["Positive"],"call_successful":[true],"start_timestamp":{"upper_threshold":1738475421000,"lower_threshold":1738475411000},"metadata.customer_id":["cust_123"],"dynamic_variables.user_name":["John"]}
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteria
    {
        /// <summary>
        /// Only retrieve calls with specific call id(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public global::System.Collections.Generic.IList<string>? CallId { get; set; }

        /// <summary>
        /// Only retrieve calls that are made with specific agent(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public global::System.Collections.Generic.IList<string>? AgentId { get; set; }

        /// <summary>
        /// The version of the agent to use for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::System.Collections.Generic.IList<int>? Version { get; set; }

        /// <summary>
        /// Only retrieve calls with specific call status(es).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_status")]
        public global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaCallStatu>? CallStatus { get; set; }

        /// <summary>
        /// Only retrieve calls that are in voicemail or not in voicemail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_voicemail")]
        public global::System.Collections.Generic.IList<bool>? InVoicemail { get; set; }

        /// <summary>
        /// Only retrieve calls with specific disconnection reason(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? DisconnectionReason { get; set; }

        /// <summary>
        /// Only retrieve calls with specific from number(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        public global::System.Collections.Generic.IList<string>? FromNumber { get; set; }

        /// <summary>
        /// Only retrieve calls with specific to number(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        public global::System.Collections.Generic.IList<string>? ToNumber { get; set; }

        /// <summary>
        /// Only retrieve calls with specific batch call id(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call_id")]
        public global::System.Collections.Generic.IList<string>? BatchCallId { get; set; }

        /// <summary>
        /// Only retrieve calls with specific call type(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        public global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaCallTypeItem>? CallType { get; set; }

        /// <summary>
        /// Only retrieve calls with specific direction(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaDirectionItem>? Direction { get; set; }

        /// <summary>
        /// Only retrieve calls with specific user sentiment(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        public global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaUserSentimentItem>? UserSentiment { get; set; }

        /// <summary>
        /// Only retrieve calls with specific call successful(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        public global::System.Collections.Generic.IList<bool>? CallSuccessful { get; set; }

        /// <summary>
        /// Only retrieve calls with specific range of start timestamp(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public global::G.ListCallsRequestFilterCriteriaStartTimestamp? StartTimestamp { get; set; }

        /// <summary>
        /// Only retrieve calls with specific range of end timestamp(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public global::G.ListCallsRequestFilterCriteriaEndTimestamp? EndTimestamp { get; set; }

        /// <summary>
        /// Only retrieve calls with specific range of duration(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public global::G.ListCallsRequestFilterCriteriaDurationMs? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_latency_p50")]
        public global::G.ListCallsRequestFilterCriteriaE2eLatencyP50? E2eLatencyP50 { get; set; }

        /// <summary>
        /// Filter by metadata fields using dot notation (e.g., `metadata.customer_id`).<br/>
        /// Values are matched exactly as strings.<br/>
        /// Example: {"metadata.customer_id":["cust_123"]}
        /// </summary>
        /// <example>{"metadata.customer_id":["cust_123"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Metadata { get; set; }

        /// <summary>
        /// Filter by dynamic variables using dot notation (e.g., `dynamic_variables.name`).<br/>
        /// Values are matched exactly as strings.<br/>
        /// Example: {"dynamic_variables.user_name":["John"]}
        /// </summary>
        /// <example>{"dynamic_variables.user_name":["John"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteria" /> class.
        /// </summary>
        /// <param name="callId">
        /// Only retrieve calls with specific call id(s).
        /// </param>
        /// <param name="agentId">
        /// Only retrieve calls that are made with specific agent(s).
        /// </param>
        /// <param name="version">
        /// The version of the agent to use for the call.
        /// </param>
        /// <param name="callStatus">
        /// Only retrieve calls with specific call status(es).
        /// </param>
        /// <param name="inVoicemail">
        /// Only retrieve calls that are in voicemail or not in voicemail.
        /// </param>
        /// <param name="disconnectionReason">
        /// Only retrieve calls with specific disconnection reason(s).
        /// </param>
        /// <param name="fromNumber">
        /// Only retrieve calls with specific from number(s).
        /// </param>
        /// <param name="toNumber">
        /// Only retrieve calls with specific to number(s).
        /// </param>
        /// <param name="batchCallId">
        /// Only retrieve calls with specific batch call id(s).
        /// </param>
        /// <param name="callType">
        /// Only retrieve calls with specific call type(s).
        /// </param>
        /// <param name="direction">
        /// Only retrieve calls with specific direction(s).
        /// </param>
        /// <param name="userSentiment">
        /// Only retrieve calls with specific user sentiment(s).
        /// </param>
        /// <param name="callSuccessful">
        /// Only retrieve calls with specific call successful(s).
        /// </param>
        /// <param name="startTimestamp">
        /// Only retrieve calls with specific range of start timestamp(s).
        /// </param>
        /// <param name="endTimestamp">
        /// Only retrieve calls with specific range of end timestamp(s).
        /// </param>
        /// <param name="durationMs">
        /// Only retrieve calls with specific range of duration(s).
        /// </param>
        /// <param name="e2eLatencyP50"></param>
        /// <param name="metadata">
        /// Filter by metadata fields using dot notation (e.g., `metadata.customer_id`).<br/>
        /// Values are matched exactly as strings.<br/>
        /// Example: {"metadata.customer_id":["cust_123"]}
        /// </param>
        /// <param name="dynamicVariables">
        /// Filter by dynamic variables using dot notation (e.g., `dynamic_variables.name`).<br/>
        /// Values are matched exactly as strings.<br/>
        /// Example: {"dynamic_variables.user_name":["John"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCallsRequestFilterCriteria(
            global::System.Collections.Generic.IList<string>? callId,
            global::System.Collections.Generic.IList<string>? agentId,
            global::System.Collections.Generic.IList<int>? version,
            global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaCallStatu>? callStatus,
            global::System.Collections.Generic.IList<bool>? inVoicemail,
            global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? disconnectionReason,
            global::System.Collections.Generic.IList<string>? fromNumber,
            global::System.Collections.Generic.IList<string>? toNumber,
            global::System.Collections.Generic.IList<string>? batchCallId,
            global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaCallTypeItem>? callType,
            global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaDirectionItem>? direction,
            global::System.Collections.Generic.IList<global::G.ListCallsRequestFilterCriteriaUserSentimentItem>? userSentiment,
            global::System.Collections.Generic.IList<bool>? callSuccessful,
            global::G.ListCallsRequestFilterCriteriaStartTimestamp? startTimestamp,
            global::G.ListCallsRequestFilterCriteriaEndTimestamp? endTimestamp,
            global::G.ListCallsRequestFilterCriteriaDurationMs? durationMs,
            global::G.ListCallsRequestFilterCriteriaE2eLatencyP50? e2eLatencyP50,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? metadata,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? dynamicVariables)
        {
            this.CallId = callId;
            this.AgentId = agentId;
            this.Version = version;
            this.CallStatus = callStatus;
            this.InVoicemail = inVoicemail;
            this.DisconnectionReason = disconnectionReason;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.BatchCallId = batchCallId;
            this.CallType = callType;
            this.Direction = direction;
            this.UserSentiment = userSentiment;
            this.CallSuccessful = callSuccessful;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.DurationMs = durationMs;
            this.E2eLatencyP50 = e2eLatencyP50;
            this.Metadata = metadata;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequestFilterCriteria" /> class.
        /// </summary>
        public ListCallsRequestFilterCriteria()
        {
        }
    }
}