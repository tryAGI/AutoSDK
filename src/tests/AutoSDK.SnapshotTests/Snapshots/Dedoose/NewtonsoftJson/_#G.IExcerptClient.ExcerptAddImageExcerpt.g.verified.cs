//HintName: G.IExcerptClient.ExcerptAddImageExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// AddImageExcerpt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> ExcerptAddImageExcerptAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid userId = default,
            global::System.Guid resourceId = default,
            int start = default,
            int end = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIdsToApply = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}