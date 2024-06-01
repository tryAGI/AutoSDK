//HintName: G.Models.ReposCreateOrgRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateOrgRulesetRequestTarget
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
    public static class ReposCreateOrgRulesetRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateOrgRulesetRequestTarget value)
        {
            return value switch
            {
                ReposCreateOrgRulesetRequestTarget.Branch => "branch",
                ReposCreateOrgRulesetRequestTarget.Tag => "tag",
                ReposCreateOrgRulesetRequestTarget.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateOrgRulesetRequestTarget ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposCreateOrgRulesetRequestTarget.Branch,
                "tag" => ReposCreateOrgRulesetRequestTarget.Tag,
                "push" => ReposCreateOrgRulesetRequestTarget.Push,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}