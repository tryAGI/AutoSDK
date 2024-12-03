//HintName: G.Models.CreateChatCompletionRequestResponseFormatDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestResponseFormatDiscriminatorType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_schema")]
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                CreateChatCompletionRequestResponseFormatDiscriminatorType.Text => "text",
                CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonObject => "json_object",
                CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateChatCompletionRequestResponseFormatDiscriminatorType.Text,
                "json_object" => CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonObject,
                "json_schema" => CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema,
                _ => null,
            };
        }
    }
}