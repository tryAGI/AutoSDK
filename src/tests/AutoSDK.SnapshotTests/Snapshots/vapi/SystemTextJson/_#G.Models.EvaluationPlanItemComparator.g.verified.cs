//HintName: G.Models.EvaluationPlanItemComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the comparison operator to use when evaluating the extracted value against the expected value.<br/>
    /// Available operators depend on the structured output's schema type:<br/>
    /// - boolean: '=', '!='<br/>
    /// - string: '=', '!='<br/>
    /// - number/integer: '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='<br/>
    /// Example: =
    /// </summary>
    public enum EvaluationPlanItemComparator
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
    public static class EvaluationPlanItemComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationPlanItemComparator value)
        {
            return value switch
            {
                EvaluationPlanItemComparator.Eq => "eq",
                EvaluationPlanItemComparator.Gt => "gt",
                EvaluationPlanItemComparator.Gte => "gte",
                EvaluationPlanItemComparator.Lt => "lt",
                EvaluationPlanItemComparator.Lte => "lte",
                EvaluationPlanItemComparator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationPlanItemComparator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => EvaluationPlanItemComparator.Eq,
                "gt" => EvaluationPlanItemComparator.Gt,
                "gte" => EvaluationPlanItemComparator.Gte,
                "lt" => EvaluationPlanItemComparator.Lt,
                "lte" => EvaluationPlanItemComparator.Lte,
                "neq" => EvaluationPlanItemComparator.Neq,
                _ => null,
            };
        }
    }
}