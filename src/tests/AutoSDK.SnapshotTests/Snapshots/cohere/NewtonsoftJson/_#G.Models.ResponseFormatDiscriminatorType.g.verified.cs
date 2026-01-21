//HintName: G.Models.ResponseFormatDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_object")]
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                ResponseFormatDiscriminatorType.Text => "text",
                ResponseFormatDiscriminatorType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormatDiscriminatorType.Text,
                "json_object" => ResponseFormatDiscriminatorType.JsonObject,
                _ => null,
            };
        }
    }
}