//HintName: G.Models.ChatCompletionServiceTier2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionServiceTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionServiceTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionServiceTier2 value)
        {
            return value switch
            {
                ChatCompletionServiceTier2.Auto => "auto",
                ChatCompletionServiceTier2.Default => "default",
                ChatCompletionServiceTier2.Flex => "flex",
                ChatCompletionServiceTier2.Priority => "priority",
                ChatCompletionServiceTier2.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionServiceTier2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionServiceTier2.Auto,
                "default" => ChatCompletionServiceTier2.Default,
                "flex" => ChatCompletionServiceTier2.Flex,
                "priority" => ChatCompletionServiceTier2.Priority,
                "scale" => ChatCompletionServiceTier2.Scale,
                _ => null,
            };
        }
    }
}