//HintName: G.IExcerptClient.ExcerptGetExcerptsByProjectId.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// GetExcerptsByProjectId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> ExcerptGetExcerptsByProjectIdAsync(
            string? token = default,
            global::System.Guid projectId = default,
            int page = default,
            int pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}