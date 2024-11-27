//HintName: G.ITagClient.StartImportTagsJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// StartImportTagsJob<br/>
        /// StartImportTagsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportTagsJobAsync(
            global::G.StartImportTagsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartImportTagsJob<br/>
        /// StartImportTagsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagVOs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportTagsJobAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.TagImportVO> tagVOs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}