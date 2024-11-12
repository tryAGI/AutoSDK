//HintName: G.IExcerptClient.ExcerptDeleteExcerpt.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// DeleteExcerpt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="excerptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptDeleteExcerptAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? excerptId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}