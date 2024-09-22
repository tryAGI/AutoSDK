//HintName: G.Models.ReposUpdateOrgRulesetRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset<br/>
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateOrgRulesetRequestTarget
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
        /// The `push` target is in beta and is subject to change.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
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
                ReposUpdateOrgRulesetRequestTarget.Tag => "tag",
                ReposUpdateOrgRulesetRequestTarget.Push => "push",
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
                "tag" => ReposUpdateOrgRulesetRequestTarget.Tag,
                "push" => ReposUpdateOrgRulesetRequestTarget.Push,
                _ => null,
            };
        }
    }
}