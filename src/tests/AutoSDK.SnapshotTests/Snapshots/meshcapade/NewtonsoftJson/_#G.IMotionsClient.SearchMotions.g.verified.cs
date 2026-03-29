//HintName: G.IMotionsClient.SearchMotions.g.cs
#nullable enable

namespace G
{
    public partial interface IMotionsClient
    {
        /// <summary>
        /// Search motions by text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetListResponse> SearchMotionsAsync(

            global::G.SearchMotionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search motions by text
        /// </summary>
        /// <param name="text">
        /// Text prompt for motion search
        /// </param>
        /// <param name="numMotions">
        /// Number of results to return
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetListResponse> SearchMotionsAsync(
            string? text = default,
            int? numMotions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}