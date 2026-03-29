//HintName: G.IVoicesClient.CreateVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a custom voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnVoice> CreateVoiceAsync(

            global::G.PostedVoice request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom voice
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnVoice> CreateVoiceAsync(
            string generationId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}