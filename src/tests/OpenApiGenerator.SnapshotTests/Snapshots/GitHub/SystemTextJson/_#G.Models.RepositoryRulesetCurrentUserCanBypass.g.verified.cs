//HintName: G.Models.RepositoryRulesetCurrentUserCanBypass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The bypass type of the user making the API request for this ruleset. This field is only returned when
    /// querying the repository-level endpoint.
    /// </summary>
    public abstract class RepositoryRulesetCurrentUserCanBypass
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Always = "always";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestsOnly = "pull_requests_only";
        /// <summary>
        /// 
        /// </summary>
        public const string Never = "never";
    }
}