//HintName: G.Models.PermissionGranteeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Immutable. The type of the grantee.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PermissionGranteeType
    {
        /// <summary>
        /// Represents access to everyone. No extra information is required.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EVERYONE")]
        Everyone,
        /// <summary>
        /// The default value. This value is unused.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GRANTEE_TYPE_UNSPECIFIED")]
        GranteeTypeUnspecified,
        /// <summary>
        /// Represents a group. When set, you must provide email_address for the group.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GROUP")]
        Group,
        /// <summary>
        /// Represents a user. When set, you must provide email_address for the user.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionGranteeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionGranteeType value)
        {
            return value switch
            {
                PermissionGranteeType.Everyone => "EVERYONE",
                PermissionGranteeType.GranteeTypeUnspecified => "GRANTEE_TYPE_UNSPECIFIED",
                PermissionGranteeType.Group => "GROUP",
                PermissionGranteeType.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionGranteeType? ToEnum(string value)
        {
            return value switch
            {
                "EVERYONE" => PermissionGranteeType.Everyone,
                "GRANTEE_TYPE_UNSPECIFIED" => PermissionGranteeType.GranteeTypeUnspecified,
                "GROUP" => PermissionGranteeType.Group,
                "USER" => PermissionGranteeType.User,
                _ => null,
            };
        }
    }
}