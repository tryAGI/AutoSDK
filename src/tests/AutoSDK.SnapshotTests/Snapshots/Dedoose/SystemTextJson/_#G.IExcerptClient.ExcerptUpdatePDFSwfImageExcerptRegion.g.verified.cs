//HintName: G.IExcerptClient.ExcerptUpdatePDFSwfImageExcerptRegion.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdatePDFSwfImageExcerptRegion.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdatePDFSwfImageExcerptRegionAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? currentUserId = default,
            global::System.Guid? excerptId = default,
            int? newStart = default,
            int? newEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}