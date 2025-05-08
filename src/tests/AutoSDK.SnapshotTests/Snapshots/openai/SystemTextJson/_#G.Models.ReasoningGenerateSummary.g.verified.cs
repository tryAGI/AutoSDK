//HintName: G.Models.ReasoningGenerateSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Deprecated:** use `summary` instead.<br/>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.
    /// </summary>
    public enum ReasoningGenerateSummary
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningGenerateSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningGenerateSummary value)
        {
            return value switch
            {
                ReasoningGenerateSummary.Auto => "auto",
                ReasoningGenerateSummary.Concise => "concise",
                ReasoningGenerateSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningGenerateSummary? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningGenerateSummary.Auto,
                "concise" => ReasoningGenerateSummary.Concise,
                "detailed" => ReasoningGenerateSummary.Detailed,
                _ => null,
            };
        }
    }
}