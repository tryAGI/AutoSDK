//HintName: G.Models.RepositoryRulesetBypassActorBypassMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type.
    /// </summary>
    public abstract class RepositoryRulesetBypassActorBypassMode
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Always = "always";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequest = "pull_request";
    }
}