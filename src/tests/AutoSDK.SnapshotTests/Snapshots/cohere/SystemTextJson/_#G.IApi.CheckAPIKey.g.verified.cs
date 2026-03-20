//HintName: G.IApi.CheckAPIKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Check API key<br/>
        /// Checks that the api key in the Authorization header is valid and active
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckAPIKeyResponse> CheckAPIKeyAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}