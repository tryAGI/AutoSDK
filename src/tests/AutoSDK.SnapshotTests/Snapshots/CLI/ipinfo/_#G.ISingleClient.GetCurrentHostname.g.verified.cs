﻿//HintName: G.ISingleClient.GetCurrentHostname.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current hostname.<br/>
        /// Returns the current hostname.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentHostnameAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}