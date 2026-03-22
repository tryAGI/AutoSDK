//HintName: G.Models.ChatSourceMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSourceMedium
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSourceMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSourceMedium value)
        {
            return value switch
            {
                ChatSourceMedium.Audio => "audio",
                ChatSourceMedium.File => "file",
                ChatSourceMedium.Image => "image",
                ChatSourceMedium.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSourceMedium? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ChatSourceMedium.Audio,
                "file" => ChatSourceMedium.File,
                "image" => ChatSourceMedium.Image,
                "text" => ChatSourceMedium.Text,
                _ => null,
            };
        }
    }
}