//HintName: G.Models.FeedsBackfillSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsBackfillSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        public FeedsBackfillSubscriptionResponse(
            string workflowId)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionResponse" /> class.
        /// </summary>
        public FeedsBackfillSubscriptionResponse()
        {
        }
    }
}