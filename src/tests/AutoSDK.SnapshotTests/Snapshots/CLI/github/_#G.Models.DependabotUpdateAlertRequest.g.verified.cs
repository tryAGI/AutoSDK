//HintName: G.Models.DependabotUpdateAlertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependabotUpdateAlertRequest
    {
        /// <summary>
        /// The state of the Dependabot alert.<br/>
        /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotUpdateAlertRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotUpdateAlertRequestState State { get; set; }

        /// <summary>
        /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotUpdateAlertRequestDismissedReasonJsonConverter))]
        public global::G.DependabotUpdateAlertRequestDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// An optional comment associated with dismissing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the Dependabot alert.<br/>
        /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// An optional comment associated with dismissing the alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotUpdateAlertRequest(
            global::G.DependabotUpdateAlertRequestState state,
            global::G.DependabotUpdateAlertRequestDismissedReason? dismissedReason,
            string? dismissedComment)
        {
            this.State = state;
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequest" /> class.
        /// </summary>
        public DependabotUpdateAlertRequest()
        {
        }
    }
}