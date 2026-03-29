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
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnection_reason")]
        public global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// Filter by custom analysis data fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cohort_id")]
        public global::G.AllOf<global::G.StringFilter, object>? CohortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public global::G.AllOf<global::G.EnumFilter, global::G.AlertFilterStatusCode>? StatusCode { get; set; }

        /// <summary>
        /// Deprecated: use 'disconnection_reason' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnection_reasons")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? DisconnectionReasons { get; set; }

        /// <summary>
        /// Deprecated: use 'status_code' instead. API error codes to filter on (for API Error Count metrics).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.AlertFilterErrorCodeItem>? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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