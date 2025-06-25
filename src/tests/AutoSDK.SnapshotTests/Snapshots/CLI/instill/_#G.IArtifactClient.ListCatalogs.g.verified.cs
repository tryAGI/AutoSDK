﻿//HintName: G.IArtifactClient.ListCatalogs.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get all catalogs info<br/>
        /// Returns a paginated list of catalogs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCatalogsResponse> ListCatalogsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}