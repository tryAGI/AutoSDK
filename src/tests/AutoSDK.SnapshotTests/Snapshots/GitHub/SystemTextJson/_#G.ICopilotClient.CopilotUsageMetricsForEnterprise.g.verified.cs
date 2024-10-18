//HintName: G.ICopilotClient.CopilotUsageMetricsForEnterprise.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get a summary of Copilot usage for enterprise members<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDE<br/>
        /// for all users across organizations with access to Copilot within your enterprise, with a further breakdown of suggestions, acceptances,<br/>
        /// and number of active users by editor and language for each day. See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for up to 28 days prior. Usage metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// Only owners and billing managers can view Copilot usage metrics for the enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 28
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>> CopilotUsageMetricsForEnterpriseAsync(
            string enterprise,
            string? since = default,
            string? until = default,
            int? page = 1,
            int? perPage = 28,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}