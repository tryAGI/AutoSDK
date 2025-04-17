//HintName: G.Models.CompletionJobOutJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of job (`FT` for fine-tuning).<br/>
    /// Default Value: completion
    /// </summary>
    public enum CompletionJobOutJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionJobOutJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutJobType value)
        {
            return value switch
            {
                CompletionJobOutJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutJobType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => CompletionJobOutJobType.Completion,
                _ => null,
            };
        }
    }
}