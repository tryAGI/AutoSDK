//HintName: G.IReposClient.ListRepoTags.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List Repo Tags<br/>
        /// Get all repo tags.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="matchPrefix">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListTagsResponse> ListRepoTagsAsync(
            int? limit = default,
            int? offset = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.ListRepoTagsApiV1ReposTagsGetIsArchived? isArchived = default,
            global::G.ListRepoTagsApiV1ReposTagsGetIsPublic? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            bool? matchPrefix = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}