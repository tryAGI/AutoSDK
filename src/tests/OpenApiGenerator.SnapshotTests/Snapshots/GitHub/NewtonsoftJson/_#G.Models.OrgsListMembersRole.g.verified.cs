//HintName: G.Models.OrgsListMembersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListMembersRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListMembersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListMembersRole value)
        {
            return value switch
            {
                OrgsListMembersRole.All => "all",
                OrgsListMembersRole.Admin => "admin",
                OrgsListMembersRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListMembersRole? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsListMembersRole.All,
                "admin" => OrgsListMembersRole.Admin,
                "member" => OrgsListMembersRole.Member,
                _ => null,
            };
        }
    }
}