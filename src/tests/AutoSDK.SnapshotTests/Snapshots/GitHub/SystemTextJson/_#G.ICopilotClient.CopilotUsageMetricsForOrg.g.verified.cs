//HintName: G.ICopilotClient.CopilotUsageMetricsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get a summary of Copilot usage for organization members<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDE<br/>
        /// across an organization, with a further breakdown of suggestions, acceptances, and number of active users by editor and language for each day.<br/>
        /// See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for up to 28 days prior. Usage metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// Organization owners, and owners and billing managers of the parent enterprise, can view Copilot usage metrics.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot`, `read:org`, or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>> CopilotUsageMetricsForOrgAsync(
            string org,
            string? since = default,
            string? until = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}