//HintName: G.Models.EnvironmentApprovals.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An entry in the reviews log for environment deployments
    /// </summary>
    public sealed partial class EnvironmentApprovals
    {
        /// <summary>
        /// The list of environments that were approved or rejected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<EnvironmentApprovalsEnvironments> Environments { get; set; } = default!;

        /// <summary>
        /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)
        /// <br/>Example: approved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public EnvironmentApprovalsState State { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public SimpleUser User { get; set; } = default!;

        /// <summary>
        /// The comment submitted with the deployment review
        /// <br/>Example: Ship it!
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