//HintName: G.IIntegrationClient.TestStripeMeterEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> TestStripeMeterEventAsync(
            string integrationId,

            global::G.TestStripeMeterEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="eventName"></param>
        /// <param name="customerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> TestStripeMeterEventAsync(
            string integrationId,
            string eventName,
            string customerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}