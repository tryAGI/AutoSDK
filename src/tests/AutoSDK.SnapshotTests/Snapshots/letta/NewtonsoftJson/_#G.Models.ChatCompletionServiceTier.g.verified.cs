//HintName: G.Models.ChatCompletionServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priority")]
        Priority,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale")]
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