//HintName: G.IVolumesClient.GetVolumes.g.cs
#nullable enable

namespace G
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// List all team volumes
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Volume>> GetVolumesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}