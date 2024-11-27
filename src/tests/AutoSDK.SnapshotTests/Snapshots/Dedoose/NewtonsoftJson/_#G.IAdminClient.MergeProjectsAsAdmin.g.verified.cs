//HintName: G.IAdminClient.MergeProjectsAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// MergeProjects<br/>
        /// MergeProjects
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MergeProjectsAsAdminAsync(
            global::G.MergeProjectsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// MergeProjects<br/>
        /// MergeProjects
        /// </summary>
        /// <param name="project1Id"></param>
        /// <param name="project2Id"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="creatorId"></param>
        /// <param name="mergeCodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MergeProjectsAsAdminAsync(
            global::System.Guid project1Id,
            global::System.Guid project2Id,
            string newTitle,
            string newDescription,
            global::System.Guid creatorId,
            bool mergeCodes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}