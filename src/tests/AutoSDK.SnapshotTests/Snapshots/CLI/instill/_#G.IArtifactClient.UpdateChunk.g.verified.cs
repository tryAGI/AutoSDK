﻿//HintName: G.IArtifactClient.UpdateChunk.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            global::G.UpdateChunkBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="retrievable"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            bool? retrievable = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}