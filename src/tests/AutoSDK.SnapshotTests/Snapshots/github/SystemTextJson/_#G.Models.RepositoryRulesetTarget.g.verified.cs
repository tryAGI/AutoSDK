//HintName: G.Models.RepositoryRulesetTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
    /// </summary>
    public enum RepositoryRulesetTarget
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
    public static class RepositoryRulesetTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetTarget value)
        {
            return value switch
            {
                RepositoryRulesetTarget.Branch => "branch",
                RepositoryRulesetTarget.Push => "push",
                RepositoryRulesetTarget.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => RepositoryRulesetTarget.Branch,
                "push" => RepositoryRulesetTarget.Push,
                "tag" => RepositoryRulesetTarget.Tag,
                _ => null,
            };
        }
    }
}