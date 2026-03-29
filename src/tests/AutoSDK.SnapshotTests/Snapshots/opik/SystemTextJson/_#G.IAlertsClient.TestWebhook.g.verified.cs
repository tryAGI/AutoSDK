//HintName: G.IAlertsClient.TestWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Test alert webhook<br/>
        /// Test alert webhook
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookTestResult> TestWebhookAsync(

            global::G.AlertWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test alert webhook<br/>
        /// Test alert webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="alertType"></param>
        /// <param name="metadata"></param>
        /// <param name="webhook"></param>
        /// <param name="triggers"></param>
        /// <param name="projectId">
        /// Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookTestResult> TestWebhookAsync(
            global::G.WebhookWrite webhook,
            global::System.Guid? id = default,
            string? name = default,
            bool? enabled = default,
            global::G.AlertWriteAlertType? alertType = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>? triggers = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}