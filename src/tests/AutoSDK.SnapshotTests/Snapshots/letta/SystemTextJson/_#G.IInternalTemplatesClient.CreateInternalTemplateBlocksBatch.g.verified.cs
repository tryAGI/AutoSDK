//HintName: G.IInternalTemplatesClient.CreateInternalTemplateBlocksBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Create Blocks Batch<br/>
        /// Create multiple blocks with template-related fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Block>> CreateInternalTemplateBlocksBatchAsync(

            global::System.Collections.Generic.IList<global::G.InternalTemplateBlockCreate> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}