//HintName: G.IApi.PatentSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatentSearchResponse> PatentSearchAsync(

            global::G.PatentSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatentSearchResponse> PatentSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}