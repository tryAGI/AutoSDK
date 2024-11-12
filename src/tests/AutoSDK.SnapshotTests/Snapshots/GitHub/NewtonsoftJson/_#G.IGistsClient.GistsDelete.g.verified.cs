//HintName: G.IGistsClient.GistsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Delete a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GistsDeleteAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}