//HintName: G.IVolumesClient.GetVolumesByVolumeID.g.cs
#nullable enable

namespace G
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Get team volume info
        /// </summary>
        /// <param name="volumeID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VolumeAndToken> GetVolumesByVolumeIDAsync(
            string volumeID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}