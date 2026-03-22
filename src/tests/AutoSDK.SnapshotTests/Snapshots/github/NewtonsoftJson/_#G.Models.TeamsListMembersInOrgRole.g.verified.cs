//HintName: G.Models.TeamsListMembersInOrgRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsListMembersInOrgRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintainer")]
        Maintainer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
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
                TeamsListMembersInOrgRole.All => "all",
                TeamsListMembersInOrgRole.Maintainer => "maintainer",
                TeamsListMembersInOrgRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListMembersInOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "all" => TeamsListMembersInOrgRole.All,
                "maintainer" => TeamsListMembersInOrgRole.Maintainer,
                "member" => TeamsListMembersInOrgRole.Member,
                _ => null,
            };
        }
    }
}