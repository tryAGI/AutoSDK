//HintName: G.Models.ActionsCreateSelfHostedRunnerGroupForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCreateSelfHostedRunnerGroupForOrgRequest
    {
        /// <summary>
        /// Name of the runner group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
        /// Default Value: all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// List of repository IDs that can access the runner group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// List of runner IDs to add to the runner group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runners")]
        public global::System.Collections.Generic.IList<int>? Runners { get; set; }

        /// <summary>
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allows_public_repositories")]
        public bool? AllowsPublicRepositories { get; set; }

        /// <summary>
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restricted_to_workflows")]
        public bool? RestrictedToWorkflows { get; set; }

        /// <summary>
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_workflows")]
        public global::System.Collections.Generic.IList<string>? SelectedWorkflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateSelfHostedRunnerGroupForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="allowsPublicRepositories">
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        public ActionsCreateSelfHostedRunnerGroupForOrgRequest(
            string name,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
            global::System.Collections.Generic.IList<int>? runners,
            bool? allowsPublicRepositories,
            bool? restrictedToWorkflows,
            global::System.Collections.Generic.IList<string>? selectedWorkflows)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.SelectedRepositoryIds = selectedRepositoryIds;
            this.Runners = runners;
            this.AllowsPublicRepositories = allowsPublicRepositories;
            this.RestrictedToWorkflows = restrictedToWorkflows;
            this.SelectedWorkflows = selectedWorkflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateSelfHostedRunnerGroupForOrgRequest" /> class.
        /// </summary>
        public ActionsCreateSelfHostedRunnerGroupForOrgRequest()
        {
        }
    }
}