//HintName: G.Models.CreateChatCompletionResponseServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service tier used for processing the request.<br/>
    /// Example: scale
    /// </summary>
    public enum CreateChatCompletionResponseServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionResponseServiceTier.Scale => "scale",
                CreateChatCompletionResponseServiceTier.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "scale" => CreateChatCompletionResponseServiceTier.Scale,
                "default" => CreateChatCompletionResponseServiceTier.Default,
                _ => null,
            };
        }
    }
}