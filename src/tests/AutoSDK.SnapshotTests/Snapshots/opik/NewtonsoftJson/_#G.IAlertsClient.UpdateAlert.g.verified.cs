//HintName: G.IAlertsClient.UpdateAlert.g.cs
#nullable enable

namespace G
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Update alert<br/>
        /// Update alert
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAlertAsync(
            global::System.Guid id,

            global::G.AlertWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update alert<br/>
        /// Update alert
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
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
        global::System.Threading.Tasks.Task UpdateAlertAsync(
            global::System.Guid id,
            global::G.WebhookWrite webhook,
            global::System.Guid? requestId = default,
            string? name = default,
            bool? enabled = default,
            global::G.AlertWriteAlertType? alertType = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>? triggers = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}