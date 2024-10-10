//HintName: G.IApi.RedirectToMintlifyDocsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Redirect To Mintlify
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedirectToMintlifyDocsGetResponse> RedirectToMintlifyDocsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}