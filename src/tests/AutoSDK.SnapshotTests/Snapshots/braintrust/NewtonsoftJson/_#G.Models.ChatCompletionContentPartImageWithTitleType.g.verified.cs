//HintName: G.Models.ChatCompletionContentPartImageWithTitleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartImageWithTitleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageWithTitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleType value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatCompletionContentPartImageWithTitleType.ImageUrl,
                _ => null,
            };
        }
    }
}