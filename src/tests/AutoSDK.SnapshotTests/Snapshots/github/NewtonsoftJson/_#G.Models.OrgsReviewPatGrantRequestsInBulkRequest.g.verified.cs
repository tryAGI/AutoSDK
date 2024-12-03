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
        [global::Newtonsoft.Json.JsonProperty("pat_request_ids")]
        public global::System.Collections.Generic.IList<int>? PatRequestIds { get; set; }

        /// <summary>
        /// Action to apply to the requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgsReviewPatGrantRequestsInBulkRequestAction Action { get; set; } = default!;

        /// <summary>
        /// Reason for approving or denying the requests. Max 1024 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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