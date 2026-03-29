//HintName: G.Models.CallFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter criteria for calls. All conditions are implicitly connected with AND.
    /// </summary>
    public sealed partial class CallFilter
    {
        /// <summary>
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public global::G.StringFilter? CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call_id")]
        public global::G.StringFilter? BatchCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterCallStatus>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterCallStatus>? CallStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_voicemail")]
        public global::G.BooleanFilter? InVoicemail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterDisconnectionReason>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        public global::G.StringFilter? FromNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        public global::G.StringFilter? ToNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterCallType>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterCallType>? CallType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterDirection>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDirection>? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterUserSentiment>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterUserSentiment>? UserSentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.CallFilterDataStorageSetting>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDataStorageSetting>? DataStorageSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        public global::G.BooleanFilter? CallSuccessful { get; set; }

        /// <summary>
        /// Filter by call start timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// Filter by call end timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? EndTimestamp { get; set; }

        /// <summary>
        /// Filter by call duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? DurationMs { get; set; }

        /// <summary>
        /// Filter by combined cost of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? CombinedCost { get; set; }

        /// <summary>
        /// Filter by end-to-end latency p50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_latency_p50")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? E2eLatencyP50 { get; set; }

        /// <summary>
        /// Filter by tool call criteria. Tool call filters are connected by AND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallFilter>? ToolCalls { get; set; }

        /// <summary>
        /// Filter by custom analysis data fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// Filter by custom attributes fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attributes")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? CustomAttributes { get; set; }

        /// <summary>
        /// Filter by metadata fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? Metadata { get; set; }

        /// <summary>
        /// Filter by dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.StringFilter, global::G.CallFilterDynamicVariable>>? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </param>
        /// <param name="callId"></param>
        /// <param name="batchCallId"></param>
        /// <param name="callStatus"></param>
        /// <param name="inVoicemail"></param>
        /// <param name="disconnectionReason"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="callType"></param>
        /// <param name="direction"></param>
        /// <param name="userSentiment"></param>
        /// <param name="dataStorageSetting"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="startTimestamp">
        /// Filter by call start timestamp (epoch ms).
        /// </param>
        /// <param name="endTimestamp">
        /// Filter by call end timestamp (epoch ms).
        /// </param>
        /// <param name="durationMs">
        /// Filter by call duration in milliseconds.
        /// </param>
        /// <param name="combinedCost">
        /// Filter by combined cost of the call.
        /// </param>
        /// <param name="e2eLatencyP50">
        /// Filter by end-to-end latency p50.
        /// </param>
        /// <param name="toolCalls">
        /// Filter by tool call criteria. Tool call filters are connected by AND.
        /// </param>
        /// <param name="customAnalysisData">
        /// Filter by custom analysis data fields.
        /// </param>
        /// <param name="customAttributes">
        /// Filter by custom attributes fields.
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata fields.
        /// </param>
        /// <param name="dynamicVariables">
        /// Filter by dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallFilter(
            global::System.Collections.Generic.IList<global::G.AgentFilter>? agent,
            global::G.StringFilter? callId,
            global::G.StringFilter? batchCallId,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterCallStatus>? callStatus,
            global::G.BooleanFilter? inVoicemail,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDisconnectionReason>? disconnectionReason,
            global::G.StringFilter? fromNumber,
            global::G.StringFilter? toNumber,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterCallType>? callType,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDirection>? direction,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterUserSentiment>? userSentiment,
            global::G.AllOf<global::G.EnumFilter, global::G.CallFilterDataStorageSetting>? dataStorageSetting,
            global::G.BooleanFilter? callSuccessful,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? startTimestamp,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? endTimestamp,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? durationMs,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? combinedCost,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? e2eLatencyP50,
            global::System.Collections.Generic.IList<global::G.ToolCallFilter>? toolCalls,
            global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? customAnalysisData,
            global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? customAttributes,
            global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? metadata,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.StringFilter, global::G.CallFilterDynamicVariable>>? dynamicVariables)
        {
            this.Agent = agent;
            this.CallId = callId;
            this.BatchCallId = batchCallId;
            this.CallStatus = callStatus;
            this.InVoicemail = inVoicemail;
            this.DisconnectionReason = disconnectionReason;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.CallType = callType;
            this.Direction = direction;
            this.UserSentiment = userSentiment;
            this.DataStorageSetting = dataStorageSetting;
            this.CallSuccessful = callSuccessful;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.DurationMs = durationMs;
            this.CombinedCost = combinedCost;
            this.E2eLatencyP50 = e2eLatencyP50;
            this.ToolCalls = toolCalls;
            this.CustomAnalysisData = customAnalysisData;
            this.CustomAttributes = customAttributes;
            this.Metadata = metadata;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilter" /> class.
        /// </summary>
        public CallFilter()
        {
        }
    }
}