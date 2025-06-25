﻿//HintName: G.IFilesClient.RetrieveFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns information about a specific file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIFile> RetrieveFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}