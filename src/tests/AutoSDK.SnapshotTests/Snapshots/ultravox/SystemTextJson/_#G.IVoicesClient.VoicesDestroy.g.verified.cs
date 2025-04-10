//HintName: G.IVoicesClient.VoicesDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task VoicesDestroyAsync(
            global::System.Guid voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}