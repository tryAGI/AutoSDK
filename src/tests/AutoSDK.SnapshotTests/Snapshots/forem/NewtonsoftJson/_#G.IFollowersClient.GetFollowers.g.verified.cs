//HintName: G.IFollowersClient.GetFollowers.g.cs
#nullable enable

namespace G
{
    public partial interface IFollowersClient
    {
        /// <summary>
        /// Followers<br/>
        /// This endpoint allows the client to retrieve a list of the followers they have.<br/>
        ///         "Followers" are users that are following other users on the website.<br/>
        ///         It supports pagination, each page will contain 80 followers by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GetFollowersResponseItem>> GetFollowersAsync(
            int? page = default,
            int? perPage = default,
            string? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}