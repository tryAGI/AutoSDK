﻿//HintName: G.Models.EnvironmentApprovals.g.cs

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
        public global::System.Collections.Generic.IList<global::G.EnvironmentApprovalsEnvironment> Environments { get; set; } = default!;

        /// <summary>
        /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)<br/>
        /// Example: approved
        /// </summary>
        /// <example>approved</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnvironmentApprovalsState State { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser User { get; set; } = default!;

        /// <summary>
        /// The comment submitted with the deployment review<br/>
        /// Example: Ship it!
        /// </summary>
        /// <example>Ship it!</example>
        [global::Newtonsoft.Json.JsonProperty("comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Comment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentApprovals" /> class.
        /// </summary>
        /// <param name="environments">
        /// The list of environments that were approved or rejected
        /// </param>
        /// <param name="state">
        /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)<br/>
        /// Example: approved
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="comment">
        /// The comment submitted with the deployment review<br/>
        /// Example: Ship it!
        /// </param>
        public EnvironmentApprovals(
            global::System.Collections.Generic.IList<global::G.EnvironmentApprovalsEnvironment> environments,
            global::G.EnvironmentApprovalsState state,
            global::G.SimpleUser user,
            string comment)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.State = state;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentApprovals" /> class.
        /// </summary>
        public EnvironmentApprovals()
        {
        }
    }
}