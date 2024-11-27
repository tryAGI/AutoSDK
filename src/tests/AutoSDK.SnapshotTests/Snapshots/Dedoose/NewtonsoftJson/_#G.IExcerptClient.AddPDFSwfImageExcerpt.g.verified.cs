//HintName: G.IExcerptClient.AddPDFSwfImageExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// AddPDFSwfImageExcerpt<br/>
        /// AddPDFSwfImageExcerpt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFSwfImageExcerptAsync(
            global::G.AddPDFSwfImageExcerptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddPDFSwfImageExcerpt<br/>
        /// AddPDFSwfImageExcerpt
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFSwfImageExcerptAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<global::System.Guid> tagIdsToApply,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}