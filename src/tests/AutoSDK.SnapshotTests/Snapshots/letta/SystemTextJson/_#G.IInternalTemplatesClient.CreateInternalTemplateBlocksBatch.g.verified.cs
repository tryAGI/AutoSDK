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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Block>> CreateInternalTemplateBlocksBatchAsync(

            global::System.Collections.Generic.IList<global::G.InternalTemplateBlockCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}