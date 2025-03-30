//HintName: G.IPublicClient.ReadSharedDatasetTracerSessionsBulk.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Tracer Sessions Bulk<br/>
        /// Get sessions from multiple datasets using share tokens.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TracerSession>> ReadSharedDatasetTracerSessionsBulkAsync(
            global::System.Collections.Generic.IList<string> shareTokens,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}