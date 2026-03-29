//HintName: G.IApi.GetCreditsV1CreditsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the user's credits<br/>
        /// Get the user's credits
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreditsResponse> GetCreditsV1CreditsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}