//HintName: G.Models.ChatCompletionContentPartImageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartImageType
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
    public static class ChatCompletionContentPartImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageType value)
        {
            return value switch
            {
                ChatCompletionContentPartImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatCompletionContentPartImageType.ImageUrl,
                _ => null,
            };
        }
    }
}