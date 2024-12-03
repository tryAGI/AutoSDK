//HintName: G.Models.TeamMembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the user in the team.<br/>
    /// Default Value: member<br/>
    /// Example: member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintainer")]
        Maintainer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipRole value)
        {
            return value switch
            {
                TeamMembershipRole.Member => "member",
                TeamMembershipRole.Maintainer => "maintainer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamMembershipRole.Member,
                "maintainer" => TeamMembershipRole.Maintainer,
                _ => null,
            };
        }
    }
}