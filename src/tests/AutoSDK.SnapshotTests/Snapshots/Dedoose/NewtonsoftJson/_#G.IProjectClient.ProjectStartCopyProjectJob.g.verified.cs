//HintName: G.IProjectClient.ProjectStartCopyProjectJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartCopyProjectJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProjectStartCopyProjectJobAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Guid? projectId = default,
            string? title = default,
            string? decription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}