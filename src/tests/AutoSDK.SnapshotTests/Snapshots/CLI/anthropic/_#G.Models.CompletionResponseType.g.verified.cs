//HintName: G.Models.CompletionResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Text Completions, this is always `"completion"`.<br/>
    /// Default Value: completion
    /// </summary>
    public enum CompletionResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionResponseType value)
        {
            return value switch
            {
                CompletionResponseType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionResponseType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => CompletionResponseType.Completion,
                _ => null,
            };
        }
    }
}