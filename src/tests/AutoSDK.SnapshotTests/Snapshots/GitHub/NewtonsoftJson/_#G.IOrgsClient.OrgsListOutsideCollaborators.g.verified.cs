//HintName: G.IOrgsClient.OrgsListOutsideCollaborators.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List outside collaborators for an organization<br/>
        /// List all users who are outside collaborators of an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> OrgsListOutsideCollaboratorsAsync(
            string org,
            global::G.OrgsListOutsideCollaboratorsFilter? filter = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}