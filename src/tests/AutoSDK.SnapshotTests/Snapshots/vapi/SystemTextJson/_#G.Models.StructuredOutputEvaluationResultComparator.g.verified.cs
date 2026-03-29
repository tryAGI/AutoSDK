//HintName: G.Models.StructuredOutputEvaluationResultComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the comparison operator used for evaluation.
    /// </summary>
    public enum StructuredOutputEvaluationResultComparator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredOutputEvaluationResultComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredOutputEvaluationResultComparator value)
        {
            return value switch
            {
                StructuredOutputEvaluationResultComparator.Eq => "eq",
                StructuredOutputEvaluationResultComparator.Gt => "gt",
                StructuredOutputEvaluationResultComparator.Gte => "gte",
                StructuredOutputEvaluationResultComparator.Lt => "lt",
                StructuredOutputEvaluationResultComparator.Lte => "lte",
                StructuredOutputEvaluationResultComparator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredOutputEvaluationResultComparator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => StructuredOutputEvaluationResultComparator.Eq,
                "gt" => StructuredOutputEvaluationResultComparator.Gt,
                "gte" => StructuredOutputEvaluationResultComparator.Gte,
                "lt" => StructuredOutputEvaluationResultComparator.Lt,
                "lte" => StructuredOutputEvaluationResultComparator.Lte,
                "neq" => StructuredOutputEvaluationResultComparator.Neq,
                _ => null,
            };
        }
    }
}