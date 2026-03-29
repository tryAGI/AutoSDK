//HintName: G.IStructuredOutputsClient.StructuredOutputControllerRemove.g.cs
#nullable enable

namespace G
{
    public partial interface IStructuredOutputsClient
    {
        /// <summary>
        /// Delete Structured Output
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}