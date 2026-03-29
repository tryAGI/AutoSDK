//HintName: G.IFlowsClient.UpdateFlowMonitoring.g.cs
#nullable enable

namespace G
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Update Flow Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FlowResponse> UpdateFlowMonitoringAsync(
            string id,

            global::G.UpdateMonitoringRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Flow Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FlowResponse> UpdateFlowMonitoringAsync(
            string id,
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestActivateItem>? activate = default,
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestDeactivateItem>? deactivate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}