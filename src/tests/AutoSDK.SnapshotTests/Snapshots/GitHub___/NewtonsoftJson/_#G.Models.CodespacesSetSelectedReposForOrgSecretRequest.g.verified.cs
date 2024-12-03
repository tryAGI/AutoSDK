//HintName: G.Models.CodespacesSetSelectedReposForOrgSecretRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesSetSelectedReposForOrgSecretRequest
    {
        /// <summary>
        /// An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can add and remove individual repositories using the [Set selected repositories for an organization secret](https://docs.github.com/rest/codespaces/organization-secrets#set-selected-repositories-for-an-organization-secret) and [Remove selected repository from an organization secret](https://docs.github.com/rest/codespaces/organization-secrets#remove-selected-repository-from-an-organization-secret) endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repository_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> SelectedRepositoryIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesSetSelectedReposForOrgSecretRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can add and remove individual repositories using the [Set selected repositories for an organization secret](https://docs.github.com/rest/codespaces/organization-secrets#set-selected-repositories-for-an-organization-secret) and [Remove selected repository from an organization secret](https://docs.github.com/rest/codespaces/organization-secrets#remove-selected-repository-from-an-organization-secret) endpoints.
        /// </param>
        public CodespacesSetSelectedReposForOrgSecretRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesSetSelectedReposForOrgSecretRequest" /> class.
        /// </summary>
        public CodespacesSetSelectedReposForOrgSecretRequest()
        {
        }
    }
}