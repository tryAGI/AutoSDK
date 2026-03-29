//HintName: G.IApiKeyClient.CreateAPIKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateAPIKeyResponseVariant1, global::G.CreateAPIKeyResponseVariant2>> CreateAPIKeyAsync(

            global::G.CreateAPIKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyPermissions"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateAPIKeyResponseVariant1, global::G.CreateAPIKeyResponseVariant2>> CreateAPIKeyAsync(
            string apiKeyName,
            global::G.CreateAPIKeyRequestKeyPermissions? keyPermissions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}