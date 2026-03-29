//HintName: G.IVolumesClient.CreateVolumes.g.cs
#nullable enable

namespace G
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Create a new team volume
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VolumeAndToken> CreateVolumesAsync(

            global::G.NewVolume request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new team volume
        /// </summary>
        /// <param name="name">
        /// Name of the volume
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VolumeAndToken> CreateVolumesAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}