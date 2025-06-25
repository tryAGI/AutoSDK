﻿//HintName: G.ISingleClient.GetCurrentRegion.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current region.<br/>
        /// Returns current region.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentRegionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}