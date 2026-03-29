//HintName: G.IVoicesClient.VoicesDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task VoicesDeleteAsync(
            global::G.VoicesDeleteCartesiaVersion cartesiaVersion,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}