//HintName: G.IReplicasClient.RenameReplica.g.cs
#nullable enable

namespace G
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Rename Replica<br/>
        /// Renames a single replica.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Replica> RenameReplicaAsync(
            string replicaId,

            global::G.RenameReplicaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Replica<br/>
        /// Renames a single replica.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="replicaName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Replica> RenameReplicaAsync(
            string replicaId,
            string replicaName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}