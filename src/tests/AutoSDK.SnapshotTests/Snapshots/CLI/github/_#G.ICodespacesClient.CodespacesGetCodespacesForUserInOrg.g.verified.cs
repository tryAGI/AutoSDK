﻿//HintName: G.ICodespacesClient.CodespacesGetCodespacesForUserInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List codespaces for a user in organization<br/>
        /// Lists the codespaces that a member of an organization has for repositories in that organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesGetCodespacesForUserInOrgResponse> CodespacesGetCodespacesForUserInOrgAsync(
            string org,
            string username,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}