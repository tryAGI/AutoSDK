//HintName: G.Models.UserDeleteResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.user.deleted")]
        OrganizationUserDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserDeleteResponseObject value)
        {
            return value switch
            {
                UserDeleteResponseObject.OrganizationUserDeleted => "organization.user.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.user.deleted" => UserDeleteResponseObject.OrganizationUserDeleted,
                _ => null,
            };
        }
    }
}