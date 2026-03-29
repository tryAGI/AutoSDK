//HintName: G.Models.ChatCompletionContentPartTextWithTitleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartTextWithTitleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartTextWithTitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartTextWithTitleType value)
        {
            return value switch
            {
                ChatCompletionContentPartTextWithTitleType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartTextWithTitleType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionContentPartTextWithTitleType.Text,
                _ => null,
            };
        }
    }
}