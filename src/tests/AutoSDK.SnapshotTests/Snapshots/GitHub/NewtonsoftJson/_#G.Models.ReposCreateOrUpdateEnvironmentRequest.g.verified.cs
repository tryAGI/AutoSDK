//HintName: G.Models.ReposCreateOrUpdateEnvironmentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateEnvironmentRequest
    {
        /// <summary>
        /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).<br/>
        /// Example: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_timer")]
        public int? WaitTimer { get; set; }

        /// <summary>
        /// Whether or not a user who created the job is prevented from approving their own job.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prevent_self_review")]
        public bool? PreventSelfReview { get; set; }

        /// <summary>
        /// The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewers")]
        public global::System.Collections.Generic.IList<global::G.ReposCreateOrUpdateEnvironmentRequestReviewer>? Reviewers { get; set; }

        /// <summary>
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_branch_policy")]
        public global::G.DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}