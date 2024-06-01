//HintName: G.Models.OrgsSetMembershipForUserRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role to give the user in the organization. Can be one of:  
    ///  * `admin` - The user will become an owner of the organization.  
    ///  * `member` - The user will become a non-owner member of the organization.
    /// <br/>Default Value: member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsSetMembershipForUserRequestRole
    {
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
    public static class OrgsSetMembershipForUserRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsSetMembershipForUserRequestRole value)
        {
            return value switch
            {
                OrgsSetMembershipForUserRequestRole.Admin => "admin",
                OrgsSetMembershipForUserRequestRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsSetMembershipForUserRequestRole ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgsSetMembershipForUserRequestRole.Admin,
                "member" => OrgsSetMembershipForUserRequestRole.Member,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}