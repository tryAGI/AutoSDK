//HintName: G.IAdminClient.CreateNodesByNodeID.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Change status of a node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateNodesByNodeIDAsync(
            string nodeID,

            global::G.NodeStatusChange request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change status of a node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="clusterID">
        /// Identifier of the cluster
        /// </param>
        /// <param name="status">
        /// Status of the node
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateNodesByNodeIDAsync(
            string nodeID,
            global::G.NodeStatus status,
            global::System.Guid? clusterID = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}