//HintName: G.IReposClient.ReposGetCollaboratorPermissionLevel.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get repository permissions for a user<br/>
        /// Checks the repository permission of a collaborator. The possible repository<br/>
        /// permissions are `admin`, `write`, `read`, and `none`.<br/>
        /// *Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the<br/>
        /// `maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to the<br/>
        /// collaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The<br/>
        /// `permissions` hash can also be used to determine which base level of access the collaborator has to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryCollaboratorPermission> ReposGetCollaboratorPermissionLevelAsync(
            string owner,
            string repo,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}