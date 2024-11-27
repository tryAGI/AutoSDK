//HintName: G.IExcerptClient.AddPDFImageExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// AddPDFImageExcerpt<br/>
        /// AddPDFImageExcerpt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFImageExcerptAsync(
            global::G.AddPDFImageExcerptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddPDFImageExcerpt<br/>
        /// AddPDFImageExcerpt
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddPDFImageExcerptAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<global::System.Guid> tagIdsToApply,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}