//HintName: G.Models.AlertFilter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Filter criteria for alert rules
    /// </summary>
    public sealed partial class AlertFilter
    {
        /// <summary>
        /// Agent filters, connected by OR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.AlertFilterDisconnectionReason>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// Filter by custom analysis data fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.StringFilter, object>))]
        public global::G.AllOf<global::G.StringFilter, object>? CohortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.AlertFilterStatusCode>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterStatusCode>? StatusCode { get; set; }

        /// <summary>
        /// Deprecated: use 'disconnection_reason' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reasons")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? DisconnectionReasons { get; set; }

        /// <summary>
        /// Deprecated: use 'status_code' instead. API error codes to filter on (for API Error Count metrics).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.AlertFilterErrorCodeItem>? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Agent filters, connected by OR.
        /// </param>
        /// <param name="disconnectionReason"></param>
        /// <param name="customAnalysisData">
        /// Filter by custom analysis data fields.
        /// </param>
        /// <param name="cohortId"></param>
        /// <param name="statusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertFilter(
            global::System.Collections.Generic.IList<global::G.AgentFilter>? agent,
            global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterDisconnectionReason>? disconnectionReason,
            global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? customAnalysisData,
            global::G.AllOf<global::G.StringFilter, object>? cohortId,
            global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterStatusCode>? statusCode)
        {
            this.Agent = agent;
            this.DisconnectionReason = disconnectionReason;
            this.CustomAnalysisData = customAnalysisData;
            this.CohortId = cohortId;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilter" /> class.
        /// </summary>
        public AlertFilter()
        {
        }
    }
}