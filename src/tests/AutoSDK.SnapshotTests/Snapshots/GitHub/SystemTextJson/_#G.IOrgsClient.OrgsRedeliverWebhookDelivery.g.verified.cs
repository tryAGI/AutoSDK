//HintName: G.IOrgsClient.OrgsRedeliverWebhookDelivery.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Redeliver a delivery for an organization webhook<br/>
        /// Redeliver a delivery for a webhook configured in an organization.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="deliveryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgsRedeliverWebhookDeliveryResponse> OrgsRedeliverWebhookDeliveryAsync(
            string org,
            int hookId,
            int deliveryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}