//HintName: G.IWebhooks2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// List all webhooks<br/>
        /// List all webhooks set up for your organization.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Webhook>> ListAsync(
            string? project = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}