//HintName: G.IReposClient.ReposGetCommunityProfileMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get community profile metrics<br/>
        /// Returns all community profile metrics for a repository. The repository cannot be a fork.<br/>
        /// The returned metrics include an overall health score, the repository description, the presence of documentation, the<br/>
        /// detected code of conduct, the detected license, and the presence of ISSUE\_TEMPLATE, PULL\_REQUEST\_TEMPLATE,<br/>
        /// README, and CONTRIBUTING files.<br/>
        /// The `health_percentage` score is defined as a percentage of how many of<br/>
        /// the recommended community health files are present. For more information, see<br/>
        /// "[About community profiles for public repositories](https://docs.github.com/communities/setting-up-your-project-for-healthy-contributions/about-community-profiles-for-public-repositories)."<br/>
        /// `content_reports_enabled` is only returned for organization-owned repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CommunityProfile> ReposGetCommunityProfileMetricsAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}