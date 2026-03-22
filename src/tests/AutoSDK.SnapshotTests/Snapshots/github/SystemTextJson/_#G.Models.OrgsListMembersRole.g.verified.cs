//HintName: G.Models.OrgsListMembersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum OrgsListMembersRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
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
                OrgsListMembersRole.Admin => "admin",
                OrgsListMembersRole.All => "all",
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
                "admin" => OrgsListMembersRole.Admin,
                "all" => OrgsListMembersRole.All,
                "member" => OrgsListMembersRole.Member,
                _ => null,
            };
        }
    }
}