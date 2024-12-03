//HintName: G.Models.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestAssistantMessageContentPartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refusal")]
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestAssistantMessageContentPartDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Text => "text",
                ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Text,
                "refusal" => ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}