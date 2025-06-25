﻿//HintName: G.IAppsClient.AppsListInstallationRequestsForAuthenticatedApp.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List installation requests for the authenticated app<br/>
        /// Lists all the pending installation requests for the authenticated GitHub App.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.IntegrationInstallationRequest>> AppsListInstallationRequestsForAuthenticatedAppAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}