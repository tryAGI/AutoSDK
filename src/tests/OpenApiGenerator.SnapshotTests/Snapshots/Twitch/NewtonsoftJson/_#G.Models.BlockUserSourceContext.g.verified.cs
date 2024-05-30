//HintName: G.Models.BlockUserSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlockUserSourceContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper")]
        Whisper,
    }

    public static class BlockUserSourceContextExtensions
    {
        public static string ToValueString(this BlockUserSourceContext value)
        {
            return value switch
            {
                BlockUserSourceContext.Chat => "chat",
                BlockUserSourceContext.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BlockUserSourceContext ToEnum(string value)
        {
            return value switch
            {
                "chat" => BlockUserSourceContext.Chat,
                "whisper" => BlockUserSourceContext.Whisper,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BlockUserSourceContext ToEnum(int value)
        {
            return value switch
            {
                0 => BlockUserSourceContext.Chat,
                1 => BlockUserSourceContext.Whisper,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}