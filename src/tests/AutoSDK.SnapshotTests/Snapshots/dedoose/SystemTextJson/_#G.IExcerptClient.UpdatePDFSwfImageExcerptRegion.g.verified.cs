//HintName: G.IExcerptClient.UpdatePDFSwfImageExcerptRegion.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdatePDFSwfImageExcerptRegion<br/>
        /// UpdatePDFSwfImageExcerptRegion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdatePDFSwfImageExcerptRegionAsync(
            global::G.UpdatePDFSwfImageExcerptRegionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdatePDFSwfImageExcerptRegion<br/>
        /// UpdatePDFSwfImageExcerptRegion
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdatePDFSwfImageExcerptRegionAsync(
            global::System.Guid projectId,
            global::System.Guid currentUserId,
            global::System.Guid excerptId,
            int newStart,
            int newEnd,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}