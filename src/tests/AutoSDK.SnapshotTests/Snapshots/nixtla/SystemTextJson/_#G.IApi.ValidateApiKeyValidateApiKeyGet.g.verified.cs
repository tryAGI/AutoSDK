//HintName: G.IApi.ValidateApiKeyValidateApiKeyGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Validate Api Key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateApiKeyValidateApiKeyGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}