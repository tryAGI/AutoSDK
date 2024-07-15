//HintName: G.Models.ActionsReviewPendingDeploymentsForRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsReviewPendingDeploymentsForRunRequest
    {
        /// <summary>
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> EnvironmentIds { get; set; } = default!;

        /// <summary>
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActionsReviewPendingDeploymentsForRunRequestState State { get; set; } = default!;

        /// <summary>
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Comment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}