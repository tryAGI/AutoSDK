//HintName: G.IVoicesClient.DeleteVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete a custom voice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVoiceAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}