//HintName: G.ITracesClient.AddEvaluations.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Add span, trace, or document evaluations
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AddEvaluationsAsync(

            byte[] request,
            string? contentType = default,
            string? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}