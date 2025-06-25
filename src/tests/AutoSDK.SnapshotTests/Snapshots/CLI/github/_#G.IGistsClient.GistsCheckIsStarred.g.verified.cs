﻿//HintName: G.IGistsClient.GistsCheckIsStarred.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Check if a gist is starred
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GistsCheckIsStarredAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}