//HintName: G.Models.AssistantsApiResponseFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be one of `text` or `json_object`.
    /// <br/>Default Value: text
    /// <br/>Example: json_object
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantsApiResponseFormatType
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

    public static class AssistantsApiResponseFormatTypeExtensions
    {
        public static string ToValueString(this AssistantsApiResponseFormatType value)
        {
            return value switch
            {
                AssistantsApiResponseFormatType.Text => "text",
                AssistantsApiResponseFormatType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantsApiResponseFormatType ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantsApiResponseFormatType.Text,
                "json_object" => AssistantsApiResponseFormatType.JsonObject,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantsApiResponseFormatType ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantsApiResponseFormatType.Text,
                1 => AssistantsApiResponseFormatType.JsonObject,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}