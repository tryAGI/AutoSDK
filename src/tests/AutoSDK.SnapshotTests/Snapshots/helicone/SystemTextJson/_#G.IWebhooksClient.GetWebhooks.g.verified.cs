//HintName: G.IWebhooksClient.GetWebhooks.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString> GetWebhooksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}