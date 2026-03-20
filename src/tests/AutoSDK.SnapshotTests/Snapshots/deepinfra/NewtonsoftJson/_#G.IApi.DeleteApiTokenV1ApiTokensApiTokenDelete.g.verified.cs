//HintName: G.IApi.DeleteApiTokenV1ApiTokensApiTokenDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete Api Token
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteApiTokenV1ApiTokensApiTokenDeleteAsync(
            string apiToken,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}