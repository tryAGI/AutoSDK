//HintName: G.Models.IdentityPropertyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum to represent the type of the identity property.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IdentityPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityPropertyType value)
        {
            return value switch
            {
                IdentityPropertyType.Boolean => "boolean",
                IdentityPropertyType.Json => "json",
                IdentityPropertyType.Number => "number",
                IdentityPropertyType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => IdentityPropertyType.Boolean,
                "json" => IdentityPropertyType.Json,
                "number" => IdentityPropertyType.Number,
                "string" => IdentityPropertyType.String,
                _ => null,
            };
        }
    }
}