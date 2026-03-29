//HintName: G.IReplicasClient.CreateReplica.g.cs
#nullable enable

namespace G
{
    public partial interface IReplicasClient
    {
        /// <summary>
        /// Create Replica<br/>
        /// Create a new replica using the latest phoenix-4 model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Replica> CreateReplicaAsync(

            global::G.CreateReplicaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Replica<br/>
        /// Create a new replica using the latest phoenix-4 model.
        /// </summary>
        /// <param name="trainVideoUrl">
        /// Publicly accessible download link to the training video.
        /// </param>
        /// <param name="consentVideoUrl">
        /// Publicly accessible download link to the consent video. Required for personal replicas.
        /// </param>
        /// <param name="replicaName">
        /// Name for the replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive training status callbacks.
        /// </param>
        /// <param name="modelName">
        /// Model to use (defaults to phoenix-4).
        /// </param>
        /// <param name="replicaType">
        /// The type of replica.
        /// </param>
        /// <param name="trainAudioUrl"></param>
        /// <param name="thumbnailVideoUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Replica> CreateReplicaAsync(
            string trainVideoUrl,
            string? consentVideoUrl = default,
            string? replicaName = default,
            string? callbackUrl = default,
            global::G.CreateReplicaRequestModelName? modelName = default,
            global::G.CreateReplicaRequestReplicaType? replicaType = default,
            string? trainAudioUrl = default,
            string? thumbnailVideoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}