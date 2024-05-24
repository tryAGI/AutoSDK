//HintName: G.Models.RepositoryRulesetTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
    }
}