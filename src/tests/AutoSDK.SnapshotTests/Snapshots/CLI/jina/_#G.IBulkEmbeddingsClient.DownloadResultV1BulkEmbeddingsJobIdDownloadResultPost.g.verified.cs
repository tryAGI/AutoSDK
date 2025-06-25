﻿//HintName: G.IBulkEmbeddingsClient.DownloadResultV1BulkEmbeddingsJobIdDownloadResultPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkEmbeddingsClient
    {
        /// <summary>
        /// Download Result
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DownloadResultResponse> DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}