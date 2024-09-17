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
            int? limit = 20,
            int? offset = 0,
            global::G.AnyOf<string, object>? tenantHandle = default,
            global::G.AnyOf<global::System.Guid?, object>? tenantId = default,
            global::G.AnyOf<string, object>? query = default,
            global::G.AnyOf<bool?, object>? hasCommits = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::G.AnyOf<global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2?, object>? isArchived = default,
            global::G.AnyOf<global::G.ListRepoTagsApiV1ReposTagsGetIsPublic2?, object>? isPublic = default,
            global::G.AnyOf<string, object>? upstreamRepoOwner = default,
            global::G.AnyOf<string, object>? upstreamRepoHandle = default,
            global::G.AnyOf<bool?, object>? matchPrefix = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}