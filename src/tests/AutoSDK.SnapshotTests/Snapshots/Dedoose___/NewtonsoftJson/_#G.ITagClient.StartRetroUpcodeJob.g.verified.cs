//HintName: G.ITagClient.StartRetroUpcodeJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// StartRetroUpcodeJob<br/>
        /// StartRetroUpcodeJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartRetroUpcodeJobAsync(
            global::G.StartRetroUpcodeJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartRetroUpcodeJob<br/>
        /// StartRetroUpcodeJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartRetroUpcodeJobAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}