//HintName: G.Models.ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest
    {
        /// <summary>
        /// List of repository IDs that can access the runner group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repository_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> SelectedRepositoryIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        public ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest" /> class.
        /// </summary>
        public ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest()
        {
        }
    }
}