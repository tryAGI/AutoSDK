//HintName: G.ICloudClient.AuthAzure.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Auth Azure
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AuthAzureAsync(
            global::G.AzureAuthCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Auth Azure
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tenantId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AuthAzureAsync(
            string clientId,
            string clientSecret,
            string tenantId,
            string subscriptionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}