//HintName: G.ITriggersClient.GetTriggerInstancesActive.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// List active triggers<br/>
        /// Retrieves all active trigger instances for your project. Triggers listen for events from connected accounts (e.g., new emails, Slack messages, GitHub commits) and can invoke webhooks or workflows. Use filters to find triggers for specific users, connected accounts, or trigger types.
        /// </summary>
        /// <param name="userIds">
        /// Array of user IDs to filter triggers by
        /// </param>
        /// <param name="connectedAccountIds">
        /// Array of connected account IDs to filter triggers by
        /// </param>
        /// <param name="authConfigIds">
        /// Array of auth config IDs to filter triggers by
        /// </param>
        /// <param name="triggerIds">
        /// Array of trigger IDs to filter triggers by
        /// </param>
        /// <param name="triggerNames">
        /// Array of trigger names to filter triggers by. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="showDisabled">
        /// When set to true, includes disabled triggers in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTriggerInstancesActiveResponse> GetTriggerInstancesActiveAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Collections.Generic.IList<string>? triggerIds = default,
            global::System.Collections.Generic.IList<string>? triggerNames = default,
            bool? showDisabled = default,
            double? limit = default,
            string? cursor = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}