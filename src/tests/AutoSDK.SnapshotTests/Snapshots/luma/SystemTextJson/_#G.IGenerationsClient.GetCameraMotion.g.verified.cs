//HintName: G.IGenerationsClient.GetCameraMotion.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Get camera motions<br/>
        /// Get all possible camera motions
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetCameraMotionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}