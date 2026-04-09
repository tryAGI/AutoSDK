//HintName: G.IWebhooks2Client.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// Update webhook info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookSerializerForUpdate> UpdateAsync(
            int id,

            global::G.PatchedWebhookSerializerForUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actions">
        /// Default Value: []
        /// </param>
        /// <param name="headers">
        /// Key Value Json of headers
        /// </param>
        /// <param name="isActive">
        /// If value is False the webhook is disabled
        /// </param>
        /// <param name="sendForAllActions">
        /// If value is False - used only for actions from WebhookAction
        /// </param>
        /// <param name="sendPayload">
        /// If value is False send only action
        /// </param>
        /// <param name="url">
        /// URL of webhook
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookSerializerForUpdate> UpdateAsync(
            int id,
            global::System.Collections.Generic.IList<global::G.ActionsEnum>? actions = default,
            object? headers = default,
            bool? isActive = default,
            bool? sendForAllActions = default,
            bool? sendPayload = default,
            string? url = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}