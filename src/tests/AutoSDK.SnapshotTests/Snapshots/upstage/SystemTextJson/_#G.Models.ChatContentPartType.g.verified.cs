//HintName: G.Models.ChatContentPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    public enum ChatContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentPartType value)
        {
            return value switch
            {
                ChatContentPartType.ImageUrl => "image_url",
                ChatContentPartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatContentPartType.ImageUrl,
                "text" => ChatContentPartType.Text,
                _ => null,
            };
        }
    }
}