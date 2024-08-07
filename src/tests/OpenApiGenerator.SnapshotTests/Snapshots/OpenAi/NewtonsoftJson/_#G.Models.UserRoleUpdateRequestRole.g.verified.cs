//HintName: G.Models.UserRoleUpdateRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `reader`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserRoleUpdateRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reader")]
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRoleUpdateRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRoleUpdateRequestRole value)
        {
            return value switch
            {
                UserRoleUpdateRequestRole.Owner => "owner",
                UserRoleUpdateRequestRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRoleUpdateRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => UserRoleUpdateRequestRole.Owner,
                "reader" => UserRoleUpdateRequestRole.Reader,
                _ => null,
            };
        }
    }
}