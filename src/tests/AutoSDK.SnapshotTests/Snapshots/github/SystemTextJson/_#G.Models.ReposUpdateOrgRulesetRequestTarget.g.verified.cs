//HintName: G.Models.ReposUpdateOrgRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
    /// </summary>
    public enum ReposUpdateOrgRulesetRequestTarget
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
    public static class ReposUpdateOrgRulesetRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateOrgRulesetRequestTarget value)
        {
            return value switch
            {
                ReposUpdateOrgRulesetRequestTarget.Branch => "branch",
                ReposUpdateOrgRulesetRequestTarget.Push => "push",
                ReposUpdateOrgRulesetRequestTarget.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateOrgRulesetRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposUpdateOrgRulesetRequestTarget.Branch,
                "push" => ReposUpdateOrgRulesetRequestTarget.Push,
                "tag" => ReposUpdateOrgRulesetRequestTarget.Tag,
                _ => null,
            };
        }
    }
}