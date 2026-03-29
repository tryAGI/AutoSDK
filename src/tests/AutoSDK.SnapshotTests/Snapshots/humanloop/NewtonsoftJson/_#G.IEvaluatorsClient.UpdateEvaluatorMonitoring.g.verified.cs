//HintName: G.IEvaluatorsClient.UpdateEvaluatorMonitoring.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Update Evaluator Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluatorResponse> UpdateEvaluatorMonitoringAsync(
            string id,

            global::G.UpdateMonitoringRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluator Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluatorResponse> UpdateEvaluatorMonitoringAsync(
            string id,
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestActivateItem>? activate = default,
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestDeactivateItem>? deactivate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}