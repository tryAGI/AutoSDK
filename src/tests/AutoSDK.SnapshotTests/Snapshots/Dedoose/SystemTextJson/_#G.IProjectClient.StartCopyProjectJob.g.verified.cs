//HintName: G.IProjectClient.StartCopyProjectJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartCopyProjectJob<br/>
        /// StartCopyProjectJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartCopyProjectJobAsync(
            global::G.StartCopyProjectJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartCopyProjectJob<br/>
        /// StartCopyProjectJob
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartCopyProjectJobAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            string title,
            string decription,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}