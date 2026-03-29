//HintName: G.Models.ResponseFormatNullishJsonObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatNullishJsonObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_object")]
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatNullishJsonObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatNullishJsonObjectType value)
        {
            return value switch
            {
                ResponseFormatNullishJsonObjectType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatNullishJsonObjectType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormatNullishJsonObjectType.JsonObject,
                _ => null,
            };
        }
    }
}