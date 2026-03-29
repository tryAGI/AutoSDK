//HintName: G.IAvatarsFromSmplClient.CreateFromSMPL.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromSmplClient
    {
        /// <summary>
        /// Create avatar from .smpl codec file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateFromSMPLAsync(

            global::G.CreateFromSMPLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar from .smpl codec file
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateFromSMPLAsync(
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}