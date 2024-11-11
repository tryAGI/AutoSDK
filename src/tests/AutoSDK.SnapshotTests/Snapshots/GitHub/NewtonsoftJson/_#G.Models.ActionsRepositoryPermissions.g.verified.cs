//HintName: G.Models.ActionsRepositoryPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsRepositoryPermissions
    {
        /// <summary>
        /// Whether GitHub Actions is enabled on the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ActionsRepositoryPermissions" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether GitHub Actions is enabled on the repository.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="selectedActionsUrl">
        /// The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.
        /// </param>
        public ActionsRepositoryPermissions(
            bool enabled,
            global::G.AllowedActions? allowedActions,
            string? selectedActionsUrl)
        {
            this.Enabled = enabled;
            this.AllowedActions = allowedActions;
            this.SelectedActionsUrl = selectedActionsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsRepositoryPermissions" /> class.
        /// </summary>
        public ActionsRepositoryPermissions()
        {
        }
    }
}