﻿//HintName: G.IModelsClient.CheckBlob.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Ensures that the file blob used for a FROM or ADAPTER field exists on the server.<br/>
        /// This is checking your Ollama server and not Ollama.ai.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CheckBlobAsync(
            string digest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}