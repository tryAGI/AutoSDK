//HintName: G.IReplicasClient.ListReplicas.g.cs
#nullable enable

namespace G
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// List Replicas<br/>
        /// Returns a list of all replicas.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListReplicasResponse> ListReplicasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}