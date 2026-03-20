//HintName: G.IWebhooksClient.WebhooksList.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedWebhookList> WebhooksListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}