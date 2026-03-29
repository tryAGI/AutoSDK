//HintName: G.Models.CohortSuccessfulCriteriaOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CohortSuccessfulCriteriaOp
    {
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortSuccessfulCriteriaOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortSuccessfulCriteriaOp value)
        {
            return value switch
            {
                CohortSuccessfulCriteriaOp.Ge => "ge",
                CohortSuccessfulCriteriaOp.Gt => "gt",
                CohortSuccessfulCriteriaOp.Gte => "gte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortSuccessfulCriteriaOp? ToEnum(string value)
        {
            return value switch
            {
                "ge" => CohortSuccessfulCriteriaOp.Ge,
                "gt" => CohortSuccessfulCriteriaOp.Gt,
                "gte" => CohortSuccessfulCriteriaOp.Gte,
                _ => null,
            };
        }
    }
}