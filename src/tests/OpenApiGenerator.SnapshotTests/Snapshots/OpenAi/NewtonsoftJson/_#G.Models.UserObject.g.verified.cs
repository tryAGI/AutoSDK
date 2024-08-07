//HintName: G.Models.UserObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.user`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.user")]
        OrganizationUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserObject value)
        {
            return value switch
            {
                UserObject.OrganizationUser => "organization.user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.user" => UserObject.OrganizationUser,
                _ => null,
            };
        }
    }
}