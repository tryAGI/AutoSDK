//HintName: G.Models.PromptCachingBetaMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conversational role of the generated message.<br/>
    /// This will always be `"assistant"`.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum PromptCachingBetaMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaMessageRole value)
        {
            return value switch
            {
                PromptCachingBetaMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PromptCachingBetaMessageRole.Assistant,
                _ => null,
            };
        }
    }
}