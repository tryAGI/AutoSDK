//HintName: G.Models.CompletionDetailedJobOutJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: completion
    /// </summary>
    public enum CompletionDetailedJobOutJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionDetailedJobOutJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutJobType value)
        {
            return value switch
            {
                CompletionDetailedJobOutJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutJobType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => CompletionDetailedJobOutJobType.Completion,
                _ => null,
            };
        }
    }
}