//HintName: G.IApiKeyClient.GetProviderKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ProviderKeyRow>, global::G.GetProviderKeysResponse2>> GetProviderKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}