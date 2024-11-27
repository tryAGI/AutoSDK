//HintName: G.IExcerptClient.IsDeleteExcerptsJobComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// IsDeleteExcerptsJobComplete<br/>
        /// IsDeleteExcerptsJobComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsDeleteExcerptsJobCompleteAsync(
            global::G.IsDeleteExcerptsJobCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// IsDeleteExcerptsJobComplete<br/>
        /// IsDeleteExcerptsJobComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsDeleteExcerptsJobCompleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}