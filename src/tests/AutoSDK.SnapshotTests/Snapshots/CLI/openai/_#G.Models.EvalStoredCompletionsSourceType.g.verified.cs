//HintName: G.Models.EvalStoredCompletionsSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of source. Always `stored_completions`.<br/>
    /// Default Value: stored_completions
    /// </summary>
    public enum EvalStoredCompletionsSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        StoredCompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalStoredCompletionsSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalStoredCompletionsSourceType value)
        {
            return value switch
            {
                EvalStoredCompletionsSourceType.StoredCompletions => "stored_completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalStoredCompletionsSourceType? ToEnum(string value)
        {
            return value switch
            {
                "stored_completions" => EvalStoredCompletionsSourceType.StoredCompletions,
                _ => null,
            };
        }
    }
}