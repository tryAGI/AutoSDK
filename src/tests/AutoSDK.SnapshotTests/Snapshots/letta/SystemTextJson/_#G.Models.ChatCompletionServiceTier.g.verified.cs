//HintName: G.Models.ChatCompletionServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionServiceTier
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
    public static class ChatCompletionServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionServiceTier value)
        {
            return value switch
            {
                ChatCompletionServiceTier.Auto => "auto",
                ChatCompletionServiceTier.Default => "default",
                ChatCompletionServiceTier.Flex => "flex",
                ChatCompletionServiceTier.Priority => "priority",
                ChatCompletionServiceTier.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionServiceTier.Auto,
                "default" => ChatCompletionServiceTier.Default,
                "flex" => ChatCompletionServiceTier.Flex,
                "priority" => ChatCompletionServiceTier.Priority,
                "scale" => ChatCompletionServiceTier.Scale,
                _ => null,
            };
        }
    }
}