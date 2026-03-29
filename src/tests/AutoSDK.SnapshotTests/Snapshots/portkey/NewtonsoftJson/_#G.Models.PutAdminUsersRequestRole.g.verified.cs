//HintName: G.Models.PutAdminUsersRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PutAdminUsersRequestRole
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
    public static class PutAdminUsersRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAdminUsersRequestRole value)
        {
            return value switch
            {
                PutAdminUsersRequestRole.Admin => "admin",
                PutAdminUsersRequestRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAdminUsersRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PutAdminUsersRequestRole.Admin,
                "member" => PutAdminUsersRequestRole.Member,
                _ => null,
            };
        }
    }
}