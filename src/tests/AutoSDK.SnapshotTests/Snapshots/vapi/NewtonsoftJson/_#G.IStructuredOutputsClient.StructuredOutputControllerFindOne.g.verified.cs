//HintName: G.IStructuredOutputsClient.StructuredOutputControllerFindOne.g.cs
#nullable enable

namespace G
{
    public partial interface IStructuredOutputsClient
    {
        /// <summary>
        /// Get Structured Output
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerFindOneAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}