//HintName: G.IOrgsClient.OrgsListBlockedUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List users blocked by an organization<br/>
        /// List the users blocked by an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> OrgsListBlockedUsersAsync(
            string org,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}