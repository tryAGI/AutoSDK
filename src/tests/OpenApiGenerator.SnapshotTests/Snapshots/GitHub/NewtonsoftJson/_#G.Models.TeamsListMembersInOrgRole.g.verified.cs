//HintName: G.Models.TeamsListMembersInOrgRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsListMembersInOrgRole
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsListMembersInOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListMembersInOrgRole value)
        {
            return value switch
            {
                TeamsListMembersInOrgRole.Member => "member",
                TeamsListMembersInOrgRole.Maintainer => "maintainer",
                TeamsListMembersInOrgRole.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListMembersInOrgRole ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamsListMembersInOrgRole.Member,
                "maintainer" => TeamsListMembersInOrgRole.Maintainer,
                "all" => TeamsListMembersInOrgRole.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}