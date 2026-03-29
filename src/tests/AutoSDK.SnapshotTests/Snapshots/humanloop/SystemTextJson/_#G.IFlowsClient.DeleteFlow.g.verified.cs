//HintName: G.IFlowsClient.DeleteFlow.g.cs
#nullable enable

namespace G
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Delete Flow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFlowAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}