//HintName: G.Models.RunnerGroupsOrg.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// Link to the selected repositories resource for this runner group. Not present unless visibility was set to `selected`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runners_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunnersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosted_runners_url")]
        public string? HostedRunnersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Inherited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited_allows_public_repositories")]
        public bool? InheritedAllowsPublicRepositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allows_public_repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowsPublicRepositories { get; set; }

        /// <summary>
        /// If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_restrictions_read_only")]
        public bool? WorkflowRestrictionsReadOnly { get; set; }

        /// <summary>
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_to_workflows")]
        public bool? RestrictedToWorkflows { get; set; }

        /// <summary>
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_workflows")]
        public global::System.Collections.Generic.IList<string>? SelectedWorkflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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