//HintName: G.Models.ResponseFormatV2DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatV2DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_object")]
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatV2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatV2DiscriminatorType value)
        {
            return value switch
            {
                ResponseFormatV2DiscriminatorType.JsonObject => "json_object",
                ResponseFormatV2DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatV2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormatV2DiscriminatorType.JsonObject,
                "text" => ResponseFormatV2DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}