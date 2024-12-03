//HintName: G.IExcerptClient.AddPDFSwfTextExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// AddPDFSwfTextExcerpt<br/>
        /// AddPDFSwfTextExcerpt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFSwfTextExcerptAsync(
            global::G.AddPDFSwfTextExcerptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddPDFSwfTextExcerpt<br/>
        /// AddPDFSwfTextExcerpt
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="text"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFSwfTextExcerptAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            int pageIndex,
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}