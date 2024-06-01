//HintName: G.Models.OrgsListMembersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    public enum OrgsListMembersRole
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
                OrgsListMembersRole.All => "all",
                OrgsListMembersRole.Admin => "admin",
                OrgsListMembersRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListMembersRole ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsListMembersRole.All,
                "admin" => OrgsListMembersRole.Admin,
                "member" => OrgsListMembersRole.Member,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}