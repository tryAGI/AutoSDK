//HintName: G.Models.ChatToolChoice2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatToolChoice2
    {
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolChoice2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolChoice2 value)
        {
            return value switch
            {
                ChatToolChoice2.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolChoice2? ToEnum(string value)
        {
            return value switch
            {
                "required" => ChatToolChoice2.Required,
                _ => null,
            };
        }
    }
}