//HintName: G.Models.ChatToolChoice0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatToolChoice0
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolChoice0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolChoice0 value)
        {
            return value switch
            {
                ChatToolChoice0.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolChoice0? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChatToolChoice0.None,
                _ => null,
            };
        }
    }
}