//HintName: G.IActionsClient.ActionsRemoveSelectedRepoFromOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove selected repository from an organization secret<br/>
        /// Removes a repository from an organization secret when the `visibility`<br/>
        /// for repository access is set to `selected`. The visibility is set when you [Create<br/>
        /// or update an organization secret](https://docs.github.com/rest/actions/secrets#create-or-update-an-organization-secret).<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsRemoveSelectedRepoFromOrgSecretAsync(
            string org,
            string secretName,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}