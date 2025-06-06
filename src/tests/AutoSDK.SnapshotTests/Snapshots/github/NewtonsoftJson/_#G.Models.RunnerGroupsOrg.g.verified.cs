﻿//HintName: G.Models.RunnerGroupsOrg.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunnerGroupsOrg
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public string Visibility { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// Link to the selected repositories resource for this runner group. Not present unless visibility was set to `selected`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runners_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunnersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hosted_runners_url")]
        public string? HostedRunnersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inherited", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Inherited { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inherited_allows_public_repositories")]
        public bool? InheritedAllowsPublicRepositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allows_public_repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowsPublicRepositories { get; set; } = default!;

        /// <summary>
        /// If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_restrictions_read_only")]
        public bool? WorkflowRestrictionsReadOnly { get; set; }

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
        /// Initializes a new instance of the <see cref="RunnerGroupsOrg" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="visibility"></param>
        /// <param name="default"></param>
        /// <param name="selectedRepositoriesUrl">
        /// Link to the selected repositories resource for this runner group. Not present unless visibility was set to `selected`
        /// </param>
        /// <param name="runnersUrl"></param>
        /// <param name="hostedRunnersUrl"></param>
        /// <param name="inherited"></param>
        /// <param name="inheritedAllowsPublicRepositories"></param>
        /// <param name="allowsPublicRepositories"></param>
        /// <param name="workflowRestrictionsReadOnly">
        /// If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        public RunnerGroupsOrg(
            double id,
            string name,
            string visibility,
            bool @default,
            string runnersUrl,
            bool inherited,
            bool allowsPublicRepositories,
            string? selectedRepositoriesUrl,
            string? hostedRunnersUrl,
            bool? inheritedAllowsPublicRepositories,
            bool? workflowRestrictionsReadOnly,
            bool? restrictedToWorkflows,
            global::System.Collections.Generic.IList<string>? selectedWorkflows)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility ?? throw new global::System.ArgumentNullException(nameof(visibility));
            this.Default = @default;
            this.RunnersUrl = runnersUrl ?? throw new global::System.ArgumentNullException(nameof(runnersUrl));
            this.Inherited = inherited;
            this.AllowsPublicRepositories = allowsPublicRepositories;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
            this.HostedRunnersUrl = hostedRunnersUrl;
            this.InheritedAllowsPublicRepositories = inheritedAllowsPublicRepositories;
            this.WorkflowRestrictionsReadOnly = workflowRestrictionsReadOnly;
            this.RestrictedToWorkflows = restrictedToWorkflows;
            this.SelectedWorkflows = selectedWorkflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerGroupsOrg" /> class.
        /// </summary>
        public RunnerGroupsOrg()
        {
        }
    }
}