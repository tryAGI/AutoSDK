//HintName: G.IExcerptClient.UpdateExcerptText.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdateExcerptText<br/>
        /// UpdateExcerptText
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateExcerptTextAsync(
            global::G.UpdateExcerptTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateExcerptText<br/>
        /// UpdateExcerptText
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateExcerptTextAsync(
            global::System.Guid projectIDL,
            global::System.Guid excerptId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}