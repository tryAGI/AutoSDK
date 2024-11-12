//HintName: G.IExcerptClient.ExcerptUpdateImageExcerptRegion.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdateImageExcerptRegion.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdateImageExcerptRegionAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? excerptId = default,
            int? start = default,
            int? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}