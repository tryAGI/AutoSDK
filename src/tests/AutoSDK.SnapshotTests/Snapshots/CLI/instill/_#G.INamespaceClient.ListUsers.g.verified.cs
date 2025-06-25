﻿//HintName: G.INamespaceClient.ListUsers.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// List users<br/>
        /// Returns a paginated list of users.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListUsersResponse> ListUsersAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ListUsersView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}