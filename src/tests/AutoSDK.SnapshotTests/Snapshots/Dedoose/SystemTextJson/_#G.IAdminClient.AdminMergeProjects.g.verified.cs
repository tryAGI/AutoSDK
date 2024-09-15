//HintName: G.IAdminClient.AdminMergeProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// MergeProjects.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="project1Id"></param>
        /// <param name="project2Id"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="creatorId"></param>
        /// <param name="mergeCodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminMergeProjectsResponse> AdminMergeProjectsAsync(
            string? token = default,
            global::System.Guid project1Id = default,
            global::System.Guid project2Id = default,
            string? newTitle = default,
            string? newDescription = default,
            global::System.Guid creatorId = default,
            bool mergeCodes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}