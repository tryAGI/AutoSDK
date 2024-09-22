//HintName: G.Models.RepositoryRulesetTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset<br/>
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetTarget
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
                RepositoryRulesetTarget.Tag => "tag",
                RepositoryRulesetTarget.Push => "push",
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
                "tag" => RepositoryRulesetTarget.Tag,
                "push" => RepositoryRulesetTarget.Push,
                _ => null,
            };
        }
    }
}