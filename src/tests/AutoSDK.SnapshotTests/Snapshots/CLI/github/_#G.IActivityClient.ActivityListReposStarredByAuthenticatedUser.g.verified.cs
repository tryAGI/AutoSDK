﻿//HintName: G.IActivityClient.ActivityListReposStarredByAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List repositories starred by the authenticated user<br/>
        /// Lists repositories the authenticated user has starred.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Repository>> ActivityListReposStarredByAuthenticatedUserAsync(
            global::G.ActivityListReposStarredByAuthenticatedUserSort? sort = default,
            global::G.ActivityListReposStarredByAuthenticatedUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}