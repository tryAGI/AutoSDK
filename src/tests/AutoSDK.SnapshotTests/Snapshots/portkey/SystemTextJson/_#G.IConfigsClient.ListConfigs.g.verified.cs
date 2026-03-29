//HintName: G.IConfigsClient.ListConfigs.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// List all configs
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConfigsResponse> ListConfigsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}