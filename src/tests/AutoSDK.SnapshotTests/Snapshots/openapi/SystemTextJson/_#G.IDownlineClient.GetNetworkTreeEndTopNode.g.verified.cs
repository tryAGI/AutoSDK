//HintName: G.IDownlineClient.GetNetworkTreeEndTopNode.g.cs
#nullable enable

namespace G
{
    public partial interface IDownlineClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="side"></param>
        /// <param name="levelsToDisplay"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.NetworkTreeEndTopNodeResponseDto> GetNetworkTreeEndTopNodeAsync(
            global::G.NetworkTreeSide2 side,
            int levelsToDisplay,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}