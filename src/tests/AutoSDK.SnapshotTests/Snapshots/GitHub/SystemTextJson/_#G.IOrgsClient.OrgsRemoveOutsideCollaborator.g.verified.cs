//HintName: G.IOrgsClient.OrgsRemoveOutsideCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove outside collaborator from an organization<br/>
        /// Removing a user from this list will remove them from all the organization's repositories.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsRemoveOutsideCollaboratorAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}