﻿//HintName: G.IReposClient.ReposCreateRelease.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a release<br/>
        /// Users with push access to the repository can create a release.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Release> ReposCreateReleaseAsync(
            string owner,
            string repo,
            global::G.ReposCreateReleaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a release<br/>
        /// Users with push access to the repository can create a release.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tagName">
        /// The name of the tag.
        /// </param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository's default branch.
        /// </param>
        /// <param name="name">
        /// The name of the release.
        /// </param>
        /// <param name="body">
        /// Text describing the contents of the tag.
        /// </param>
        /// <param name="draft">
        /// `true` to create a draft (unpublished) release, `false` to create a published one.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prerelease">
        /// `true` to identify the release as a prerelease. `false` to identify the release as a full release.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="discussionCategoryName">
        /// If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. For more information, see "[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository)."
        /// </param>
        /// <param name="generateReleaseNotes">
        /// Whether to automatically generate the name and body for this release. If `name` is specified, the specified name will be used; otherwise, a name will be automatically generated. If `body` is specified, the body will be pre-pended to the automatically generated notes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="makeLatest">
        /// Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Release> ReposCreateReleaseAsync(
            string owner,
            string repo,
            string tagName,
            string? targetCommitish = default,
            string? name = default,
            string? body = default,
            bool? draft = default,
            bool? prerelease = default,
            string? discussionCategoryName = default,
            bool? generateReleaseNotes = default,
            global::G.ReposCreateReleaseRequestMakeLatest? makeLatest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}