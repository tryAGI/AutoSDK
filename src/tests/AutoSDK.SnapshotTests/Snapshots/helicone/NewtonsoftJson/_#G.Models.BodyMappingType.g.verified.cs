//HintName: G.Models.BodyMappingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyMappingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO_MAPPING")]
        NoMapping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENAI")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RESPONSES")]
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyMappingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyMappingType value)
        {
            return value switch
            {
                BodyMappingType.NoMapping => "NO_MAPPING",
                BodyMappingType.Openai => "OPENAI",
                BodyMappingType.Responses => "RESPONSES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyMappingType? ToEnum(string value)
        {
            return value switch
            {
                "NO_MAPPING" => BodyMappingType.NoMapping,
                "OPENAI" => BodyMappingType.Openai,
                "RESPONSES" => BodyMappingType.Responses,
                _ => null,
            };
        }
    }
}