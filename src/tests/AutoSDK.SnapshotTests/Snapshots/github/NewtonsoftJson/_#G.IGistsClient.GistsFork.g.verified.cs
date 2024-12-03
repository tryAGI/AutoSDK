//HintName: G.IGistsClient.GistsFork.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Fork a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BaseGist> GistsForkAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}