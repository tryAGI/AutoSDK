﻿//HintName: G.IOrgsClient.OrgsGetWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get an organization webhook<br/>
        /// Returns a webhook configured in an organization. To get only the webhook<br/>
        /// `config` properties, see "[Get a webhook configuration for an organization](/rest/orgs/webhooks#get-a-webhook-configuration-for-an-organization).<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsGetWebhookAsync(
            string org,
            int hookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}