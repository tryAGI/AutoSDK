//HintName: G.Models.ReposUpdateRepoRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
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
        Push,
        /// <summary>
        /// 
        /// </summary>
        Tag,
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
                ReposUpdateRepoRulesetRequestTarget.Push => "push",
                ReposUpdateRepoRulesetRequestTarget.Tag => "tag",
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
                "push" => ReposUpdateRepoRulesetRequestTarget.Push,
                "tag" => ReposUpdateRepoRulesetRequestTarget.Tag,
                _ => null,
            };
        }
    }
}