//HintName: G.IExcerptClient.AddVideoExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// AddVideoExcerpt<br/>
        /// AddVideoExcerpt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddVideoExcerptAsync(
            global::G.AddVideoExcerptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddVideoExcerpt<br/>
        /// AddVideoExcerpt
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> AddVideoExcerptAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<global::System.Guid> tagIdsToApply,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}