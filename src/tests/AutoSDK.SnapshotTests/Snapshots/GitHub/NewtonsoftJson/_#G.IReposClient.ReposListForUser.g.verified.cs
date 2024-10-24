//HintName: G.IReposClient.ReposListForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repositories for a user<br/>
        /// Lists public repositories for the specified user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">
        /// Default Value: owner
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> ReposListForUserAsync(
            string username,
            global::G.ReposListForUserType? type = default,
            global::G.ReposListForUserSort? sort = default,
            global::G.ReposListForUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}