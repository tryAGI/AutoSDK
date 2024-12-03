//HintName: G.ITagClient.DeleteTagByJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// DeleteTagByJob<br/>
        /// DeleteTagByJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagByJobAsync(
            global::G.DeleteTagByJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteTagByJob<br/>
        /// DeleteTagByJob
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagByJobAsync(
            global::System.Guid currentProjectId,
            global::G.Tag tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}