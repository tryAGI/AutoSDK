//HintName: G.IMemoClient.StartExportMemos.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartExportMemos<br/>
        /// StartExportMemos
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportMemosAsync(
            global::G.StartExportMemosRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportMemos<br/>
        /// StartExportMemos
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="description"></param>
        /// <param name="extension"></param>
        /// <param name="includeCodes"></param>
        /// <param name="includeMedia"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="includeDescriptors"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportMemosAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            string description,
            string extension,
            bool includeCodes,
            bool includeMedia,
            bool includeExcerpts,
            bool includeDescriptors,
            string symKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}