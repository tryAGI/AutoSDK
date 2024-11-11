//HintName: G.Models.ActionsOrganizationPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsOrganizationPermissions
    {
        /// <summary>
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnabledRepositories EnabledRepositories { get; set; } = default!;

        /// <summary>
        /// The API URL to use to get or set the selected repositories that are allowed to run GitHub Actions, when `enabled_repositories` is set to `selected`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_actions")]
        public global::G.AllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_actions_url")]
        public string? SelectedActionsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsOrganizationPermissions" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// The API URL to use to get or set the selected repositories that are allowed to run GitHub Actions, when `enabled_repositories` is set to `selected`.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="selectedActionsUrl">
        /// The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.
        /// </param>
        public ActionsOrganizationPermissions(
            global::G.EnabledRepositories enabledRepositories,
            string? selectedRepositoriesUrl,
            global::G.AllowedActions? allowedActions,
            string? selectedActionsUrl)
        {
            this.EnabledRepositories = enabledRepositories;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
            this.AllowedActions = allowedActions;
            this.SelectedActionsUrl = selectedActionsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsOrganizationPermissions" /> class.
        /// </summary>
        public ActionsOrganizationPermissions()
        {
        }
    }
}