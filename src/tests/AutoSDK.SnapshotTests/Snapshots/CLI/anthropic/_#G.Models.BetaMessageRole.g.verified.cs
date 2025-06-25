//HintName: G.Models.BetaMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conversational role of the generated message.<br/>
    /// This will always be `"assistant"`.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum BetaMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageRole value)
        {
            return value switch
            {
                BetaMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaMessageRole.Assistant,
                _ => null,
            };
        }
    }
}