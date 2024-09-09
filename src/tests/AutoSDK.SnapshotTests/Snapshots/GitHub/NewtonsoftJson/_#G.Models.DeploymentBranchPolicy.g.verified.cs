//HintName: G.Models.DeploymentBranchPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a deployment branch or tag policy.
    /// </summary>
    public sealed partial class DeploymentBranchPolicy
    {
        /// <summary>
        /// The unique identifier of the branch or tag policy.<br/>
        /// Example: 361471
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Example: MDE2OkdhdGVCcmFuY2hQb2xpY3kzNjE0NzE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Example: release/*
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether this rule targets a branch or tag.<br/>
        /// Example: branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeploymentBranchPolicyType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}