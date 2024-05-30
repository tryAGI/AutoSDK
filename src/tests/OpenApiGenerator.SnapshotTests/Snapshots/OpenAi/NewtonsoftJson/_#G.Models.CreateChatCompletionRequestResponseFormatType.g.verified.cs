//HintName: G.Models.CreateChatCompletionRequestResponseFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be one of `text` or `json_object`.
    /// <br/>Default Value: text
    /// <br/>Example: json_object
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestResponseFormatType
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

    public static class CreateChatCompletionRequestResponseFormatTypeExtensions
    {
        public static string ToValueString(this CreateChatCompletionRequestResponseFormatType value)
        {
            return value switch
            {
                CreateChatCompletionRequestResponseFormatType.Text => "text",
                CreateChatCompletionRequestResponseFormatType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestResponseFormatType ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateChatCompletionRequestResponseFormatType.Text,
                "json_object" => CreateChatCompletionRequestResponseFormatType.JsonObject,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestResponseFormatType ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionRequestResponseFormatType.Text,
                1 => CreateChatCompletionRequestResponseFormatType.JsonObject,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}