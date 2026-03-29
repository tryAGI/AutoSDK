//HintName: G.Models.ChatToolChoice1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatToolChoice1
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolChoice1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolChoice1 value)
        {
            return value switch
            {
                ChatToolChoice1.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolChoice1? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatToolChoice1.Auto,
                _ => null,
            };
        }
    }
}