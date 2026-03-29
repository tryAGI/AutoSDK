//HintName: G.IMotionsClient.DeleteMotion.g.cs
#nullable enable

namespace G
{
    public partial interface IMotionsClient
    {
        /// <summary>
        /// Delete motion
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMotionAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}