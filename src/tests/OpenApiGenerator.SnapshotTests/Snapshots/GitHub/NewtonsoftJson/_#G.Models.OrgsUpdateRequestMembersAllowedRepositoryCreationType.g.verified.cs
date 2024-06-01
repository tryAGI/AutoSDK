//HintName: G.Models.OrgsUpdateRequestMembersAllowedRepositoryCreationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. 
    /// **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsUpdateRequestMembersAllowedRepositoryCreationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsUpdateRequestMembersAllowedRepositoryCreationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsUpdateRequestMembersAllowedRepositoryCreationType value)
        {
            return value switch
            {
                OrgsUpdateRequestMembersAllowedRepositoryCreationType.All => "all",
                OrgsUpdateRequestMembersAllowedRepositoryCreationType.Private => "private",
                OrgsUpdateRequestMembersAllowedRepositoryCreationType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsUpdateRequestMembersAllowedRepositoryCreationType ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsUpdateRequestMembersAllowedRepositoryCreationType.All,
                "private" => OrgsUpdateRequestMembersAllowedRepositoryCreationType.Private,
                "none" => OrgsUpdateRequestMembersAllowedRepositoryCreationType.None,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}