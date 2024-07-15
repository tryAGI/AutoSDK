//HintName: G.Models.ReposUpdateRepoRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset<br/>
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    public enum ReposUpdateRepoRulesetRequestTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRepoRulesetRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRepoRulesetRequestTarget value)
        {
            return value switch
            {
                ReposUpdateRepoRulesetRequestTarget.Branch => "branch",
                ReposUpdateRepoRulesetRequestTarget.Tag => "tag",
                ReposUpdateRepoRulesetRequestTarget.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRepoRulesetRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposUpdateRepoRulesetRequestTarget.Branch,
                "tag" => ReposUpdateRepoRulesetRequestTarget.Tag,
                "push" => ReposUpdateRepoRulesetRequestTarget.Push,
                _ => null,
            };
        }
    }
}