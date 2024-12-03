//HintName: G.Models.CodeScanningUpdateAlertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningAlertSetState State { get; set; } = default!;

        /// <summary>
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_reason")]
        public global::G.CodeScanningAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        public CodeScanningUpdateAlertRequest(
            global::G.CodeScanningAlertSetState state,
            global::G.CodeScanningAlertDismissedReason? dismissedReason,
            string? dismissedComment)
        {
            this.State = state;
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        public CodeScanningUpdateAlertRequest()
        {
        }
    }
}