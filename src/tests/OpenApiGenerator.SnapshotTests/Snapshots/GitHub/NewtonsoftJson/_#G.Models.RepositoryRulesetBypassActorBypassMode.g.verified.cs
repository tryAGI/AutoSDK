//HintName: G.Models.RepositoryRulesetBypassActorBypassMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetBypassActorBypassMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
    }
}