//HintName: G.IAvatarsClient.CancelAvatarBuild.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Cancel avatar build
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelAvatarBuildAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}