﻿//HintName: G.Models.TeamsAddOrUpdateMembershipForUserInOrgRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role that this user should have in the team.<br/>
    /// Default Value: member
    /// </summary>
    public enum TeamsAddOrUpdateMembershipForUserInOrgRequestRole
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
    public static class TeamsAddOrUpdateMembershipForUserInOrgRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsAddOrUpdateMembershipForUserInOrgRequestRole value)
        {
            return value switch
            {
                TeamsAddOrUpdateMembershipForUserInOrgRequestRole.Member => "member",
                TeamsAddOrUpdateMembershipForUserInOrgRequestRole.Maintainer => "maintainer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsAddOrUpdateMembershipForUserInOrgRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamsAddOrUpdateMembershipForUserInOrgRequestRole.Member,
                "maintainer" => TeamsAddOrUpdateMembershipForUserInOrgRequestRole.Maintainer,
                _ => null,
            };
        }
    }
}