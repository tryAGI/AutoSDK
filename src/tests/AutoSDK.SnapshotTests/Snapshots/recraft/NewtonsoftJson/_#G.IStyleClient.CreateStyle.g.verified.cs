//HintName: G.IStyleClient.CreateStyle.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStyleResponse> CreateStyleAsync(
            global::G.CreateStyleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="images"></param>
        /// <param name="style"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            global::G.ImageStyle style,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}