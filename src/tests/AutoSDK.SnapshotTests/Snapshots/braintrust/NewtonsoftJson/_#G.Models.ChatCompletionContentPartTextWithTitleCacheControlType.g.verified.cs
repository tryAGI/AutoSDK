//HintName: G.Models.ChatCompletionContentPartTextWithTitleCacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartTextWithTitleCacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartTextWithTitleCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartTextWithTitleCacheControlType value)
        {
            return value switch
            {
                ChatCompletionContentPartTextWithTitleCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartTextWithTitleCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ChatCompletionContentPartTextWithTitleCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}