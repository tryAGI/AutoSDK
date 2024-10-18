//HintName: G.Models.RepositoryRulesetBypassActorBypassMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets.<br/>
    /// Default Value: always
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetBypassActorBypassModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetBypassActorBypassMode value)
        {
            return value switch
            {
                RepositoryRulesetBypassActorBypassMode.Always => "always",
                RepositoryRulesetBypassActorBypassMode.PullRequest => "pull_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetBypassActorBypassMode? ToEnum(string value)
        {
            return value switch
            {
                "always" => RepositoryRulesetBypassActorBypassMode.Always,
                "pull_request" => RepositoryRulesetBypassActorBypassMode.PullRequest,
                _ => null,
            };
        }
    }
}