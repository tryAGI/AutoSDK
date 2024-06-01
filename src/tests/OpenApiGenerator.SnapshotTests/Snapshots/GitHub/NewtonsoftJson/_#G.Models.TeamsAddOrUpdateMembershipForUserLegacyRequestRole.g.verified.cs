//HintName: G.Models.TeamsAddOrUpdateMembershipForUserLegacyRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role that this user should have in the team.
    /// <br/>Default Value: member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsAddOrUpdateMembershipForUserLegacyRequestRole
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
    public static class TeamsAddOrUpdateMembershipForUserLegacyRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsAddOrUpdateMembershipForUserLegacyRequestRole value)
        {
            return value switch
            {
                TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Member => "member",
                TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Maintainer => "maintainer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsAddOrUpdateMembershipForUserLegacyRequestRole ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Member,
                "maintainer" => TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Maintainer,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}