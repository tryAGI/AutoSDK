//HintName: G.IExcerptClient.UpdateExcerptRange.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdateExcerptRange<br/>
        /// UpdateExcerptRange
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateExcerptRangeAsync(
            global::G.UpdateExcerptRangeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateExcerptRange<br/>
        /// UpdateExcerptRange
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="updatedTextURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateExcerptRangeAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid excerptId,
            int newStart,
            int newEnd,
            string updatedTextURI,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}