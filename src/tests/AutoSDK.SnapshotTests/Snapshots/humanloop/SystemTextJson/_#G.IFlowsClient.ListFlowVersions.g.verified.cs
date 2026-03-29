//HintName: G.IFlowsClient.ListFlowVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// List Flow Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FlowResponse>> ListFlowVersionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}