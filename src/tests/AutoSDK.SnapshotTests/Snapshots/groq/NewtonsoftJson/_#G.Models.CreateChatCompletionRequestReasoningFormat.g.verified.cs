//HintName: G.Models.CreateChatCompletionRequestReasoningFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies how to output reasoning tokens<br/>
    /// This field is mutually exclusive with `include_reasoning`.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestReasoningFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden")]
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsed")]
        Parsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="raw")]
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestReasoningFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestReasoningFormat value)
        {
            return value switch
            {
                CreateChatCompletionRequestReasoningFormat.Hidden => "hidden",
                CreateChatCompletionRequestReasoningFormat.Parsed => "parsed",
                CreateChatCompletionRequestReasoningFormat.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestReasoningFormat? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => CreateChatCompletionRequestReasoningFormat.Hidden,
                "parsed" => CreateChatCompletionRequestReasoningFormat.Parsed,
                "raw" => CreateChatCompletionRequestReasoningFormat.Raw,
                _ => null,
            };
        }
    }
}