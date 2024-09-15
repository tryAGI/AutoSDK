//HintName: G.ITagClient.TagStartRetroUpcodeJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// StartRetroUpcodeJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagStartRetroUpcodeJobResponse> TagStartRetroUpcodeJobAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}