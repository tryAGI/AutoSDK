//HintName: G.Models.ReposUpdateRepoRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateRepoRulesetRequestTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
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
        public static ReposUpdateRepoRulesetRequestTarget ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposUpdateRepoRulesetRequestTarget.Branch,
                "tag" => ReposUpdateRepoRulesetRequestTarget.Tag,
                "push" => ReposUpdateRepoRulesetRequestTarget.Push,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}