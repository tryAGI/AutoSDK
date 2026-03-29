//HintName: G.IInfoClient.GetInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get API info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InfoResponse> GetInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}