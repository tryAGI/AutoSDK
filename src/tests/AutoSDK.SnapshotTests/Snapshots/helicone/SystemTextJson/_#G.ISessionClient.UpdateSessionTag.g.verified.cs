//HintName: G.ISessionClient.UpdateSessionTag.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateSessionTagAsync(
            string sessionId,

            global::G.UpdateSessionTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateSessionTagAsync(
            string sessionId,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}