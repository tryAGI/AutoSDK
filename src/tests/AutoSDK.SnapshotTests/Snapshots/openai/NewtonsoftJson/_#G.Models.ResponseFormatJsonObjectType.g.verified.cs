//HintName: G.Models.ResponseFormatJsonObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of response format being defined. Always `json_object`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatJsonObjectType
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
    public static class ResponseFormatJsonObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatJsonObjectType value)
        {
            return value switch
            {
                ResponseFormatJsonObjectType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatJsonObjectType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormatJsonObjectType.JsonObject,
                _ => null,
            };
        }
    }
}