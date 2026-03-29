//HintName: G.Models.PartialSessionsRequestResponseRMTToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialSessionsRequestResponseRMTToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_session_id")]
        public global::G.PartialTextOperators? SessionSessionId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_session_name")]
        public global::G.PartialTextOperators? SessionSessionName { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_cost")]
        public global::G.PartialNumberOperators? SessionTotalCost { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_tokens")]
        public global::G.PartialNumberOperators? SessionTotalTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_prompt_tokens")]
        public global::G.PartialNumberOperators? SessionPromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_completion_tokens")]
        public global::G.PartialNumberOperators? SessionCompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_requests")]
        public global::G.PartialNumberOperators? SessionTotalRequests { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_created_at")]
        public global::G.PartialTimestampOperatorsTyped? SessionCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_latest_request_created_at")]
        public global::G.PartialTimestampOperatorsTyped? SessionLatestRequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tag")]
        public global::G.PartialTextOperators? SessionTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSessionsRequestResponseRMTToOperators" /> class.
        /// </summary>
        /// <param name="sessionSessionId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionSessionName">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalCost">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionPromptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionCompletionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalRequests">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionLatestRequestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTag">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialSessionsRequestResponseRMTToOperators(
            global::G.PartialTextOperators? sessionSessionId,
            global::G.PartialTextOperators? sessionSessionName,
            global::G.PartialNumberOperators? sessionTotalCost,
            global::G.PartialNumberOperators? sessionTotalTokens,
            global::G.PartialNumberOperators? sessionPromptTokens,
            global::G.PartialNumberOperators? sessionCompletionTokens,
            global::G.PartialNumberOperators? sessionTotalRequests,
            global::G.PartialTimestampOperatorsTyped? sessionCreatedAt,
            global::G.PartialTimestampOperatorsTyped? sessionLatestRequestCreatedAt,
            global::G.PartialTextOperators? sessionTag)
        {
            this.SessionSessionId = sessionSessionId;
            this.SessionSessionName = sessionSessionName;
            this.SessionTotalCost = sessionTotalCost;
            this.SessionTotalTokens = sessionTotalTokens;
            this.SessionPromptTokens = sessionPromptTokens;
            this.SessionCompletionTokens = sessionCompletionTokens;
            this.SessionTotalRequests = sessionTotalRequests;
            this.SessionCreatedAt = sessionCreatedAt;
            this.SessionLatestRequestCreatedAt = sessionLatestRequestCreatedAt;
            this.SessionTag = sessionTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSessionsRequestResponseRMTToOperators" /> class.
        /// </summary>
        public PartialSessionsRequestResponseRMTToOperators()
        {
        }
    }
}