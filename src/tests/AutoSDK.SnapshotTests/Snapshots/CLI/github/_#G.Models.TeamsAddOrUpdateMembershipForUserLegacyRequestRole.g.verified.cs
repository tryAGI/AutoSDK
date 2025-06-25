//HintName: G.Models.TeamsAddOrUpdateMembershipForUserLegacyRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role that this user should have in the team.<br/>
    /// Default Value: member
    /// </summary>
    public enum TeamsAddOrUpdateMembershipForUserLegacyRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
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
        public static TeamsAddOrUpdateMembershipForUserLegacyRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Member,
                "maintainer" => TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Maintainer,
                _ => null,
            };
        }
    }
}