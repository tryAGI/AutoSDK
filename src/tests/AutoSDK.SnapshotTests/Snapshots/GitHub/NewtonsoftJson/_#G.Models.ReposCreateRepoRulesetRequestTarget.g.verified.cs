//HintName: G.Models.ReposCreateRepoRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset<br/>
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateRepoRulesetRequestTarget
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
    public static class ReposCreateRepoRulesetRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateRepoRulesetRequestTarget value)
        {
            return value switch
            {
                ReposCreateRepoRulesetRequestTarget.Branch => "branch",
                ReposCreateRepoRulesetRequestTarget.Tag => "tag",
                ReposCreateRepoRulesetRequestTarget.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateRepoRulesetRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposCreateRepoRulesetRequestTarget.Branch,
                "tag" => ReposCreateRepoRulesetRequestTarget.Tag,
                "push" => ReposCreateRepoRulesetRequestTarget.Push,
                _ => null,
            };
        }
    }
}