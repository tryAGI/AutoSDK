//HintName: G.Models.IdentityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum to represent the type of the identity.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IdentityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org")]
        Org,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityType value)
        {
            return value switch
            {
                IdentityType.Org => "org",
                IdentityType.Other => "other",
                IdentityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityType? ToEnum(string value)
        {
            return value switch
            {
                "org" => IdentityType.Org,
                "other" => IdentityType.Other,
                "user" => IdentityType.User,
                _ => null,
            };
        }
    }
}