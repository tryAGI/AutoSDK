//HintName: G.IMetaClient.GetMeta.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get platform metadata<br/>
        /// Returns platform metadata including webhook IP ranges for allowlisting.<br/>
        /// If your infrastructure requires allowlisting IP addresses for incoming webhook<br/>
        /// requests, this endpoint provides the current list of IP ranges used by fal.ai<br/>
        /// webhooks in CIDR notation.<br/>
        ///     
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMetaResponse> GetMetaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}