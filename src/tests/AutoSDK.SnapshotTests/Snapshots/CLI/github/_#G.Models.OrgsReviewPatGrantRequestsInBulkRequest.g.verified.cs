//HintName: G.Models.OrgsReviewPatGrantRequestsInBulkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsReviewPatGrantRequestsInBulkRequest
    {
        /// <summary>
        /// Unique identifiers of the requests for access via fine-grained personal access token. Must be formed of between 1 and 100 `pat_request_id` values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_request_ids")]
        public global::System.Collections.Generic.IList<int>? PatRequestIds { get; set; }

        /// <summary>
        /// Action to apply to the requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsReviewPatGrantRequestsInBulkRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrgsReviewPatGrantRequestsInBulkRequestAction Action { get; set; }

        /// <summary>
        /// Reason for approving or denying the requests. Max 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsReviewPatGrantRequestsInBulkRequest" /> class.
        /// </summary>
        /// <param name="patRequestIds">
        /// Unique identifiers of the requests for access via fine-grained personal access token. Must be formed of between 1 and 100 `pat_request_id` values.
        /// </param>
        /// <param name="action">
        /// Action to apply to the requests.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the requests. Max 1024 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsReviewPatGrantRequestsInBulkRequest(
            global::G.OrgsReviewPatGrantRequestsInBulkRequestAction action,
            global::System.Collections.Generic.IList<int>? patRequestIds,
            string? reason)
        {
            this.Action = action;
            this.PatRequestIds = patRequestIds;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsReviewPatGrantRequestsInBulkRequest" /> class.
        /// </summary>
        public OrgsReviewPatGrantRequestsInBulkRequest()
        {
        }
    }
}