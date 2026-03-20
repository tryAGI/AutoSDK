//HintName: G.IWebhooksClient.WebhooksDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task WebhooksDestroyAsync(
            global::System.Guid webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}