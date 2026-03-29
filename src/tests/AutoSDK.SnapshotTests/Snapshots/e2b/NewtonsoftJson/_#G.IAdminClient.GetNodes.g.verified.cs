//HintName: G.IAdminClient.GetNodes.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List all nodes
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Node>> GetNodesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}