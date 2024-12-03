//HintName: G.Models.BlockUserSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlockUserSourceContext
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockUserSourceContextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockUserSourceContext value)
        {
            return value switch
            {
                BlockUserSourceContext.Chat => "chat",
                BlockUserSourceContext.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockUserSourceContext? ToEnum(string value)
        {
            return value switch
            {
                "chat" => BlockUserSourceContext.Chat,
                "whisper" => BlockUserSourceContext.Whisper,
                _ => null,
            };
        }
    }
}