//HintName: G.Models.ChatResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResultObject value)
        {
            return value switch
            {
                ChatResultObject.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResultObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => ChatResultObject.ChatCompletion,
                _ => null,
            };
        }
    }
}