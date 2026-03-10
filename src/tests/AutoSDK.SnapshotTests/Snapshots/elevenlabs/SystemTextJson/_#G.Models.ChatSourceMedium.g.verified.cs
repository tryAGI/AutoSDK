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
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        File,
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
                ChatSourceMedium.Text => "text",
                ChatSourceMedium.Image => "image",
                ChatSourceMedium.File => "file",
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
                "text" => ChatSourceMedium.Text,
                "image" => ChatSourceMedium.Image,
                "file" => ChatSourceMedium.File,
                _ => null,
            };
        }
    }
}