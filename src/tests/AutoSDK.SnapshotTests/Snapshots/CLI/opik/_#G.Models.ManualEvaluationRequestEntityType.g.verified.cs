//HintName: G.Models.ManualEvaluationRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of entity to evaluate (trace or thread)<br/>
    /// Example: trace
    /// </summary>
    public enum ManualEvaluationRequestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Thread,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManualEvaluationRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManualEvaluationRequestEntityType value)
        {
            return value switch
            {
                ManualEvaluationRequestEntityType.Span => "span",
                ManualEvaluationRequestEntityType.Thread => "thread",
                ManualEvaluationRequestEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManualEvaluationRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => ManualEvaluationRequestEntityType.Span,
                "thread" => ManualEvaluationRequestEntityType.Thread,
                "trace" => ManualEvaluationRequestEntityType.Trace,
                _ => null,
            };
        }
    }
}