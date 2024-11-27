//HintName: G.IExcerptClient.DeleteExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// DeleteExcerpt<br/>
        /// DeleteExcerpt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> DeleteExcerptAsync(
            global::G.DeleteExcerptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteExcerpt<br/>
        /// DeleteExcerpt
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> DeleteExcerptAsync(
            global::System.Guid projectId,
            global::System.Guid excerptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}