//HintName: G.Models.PerformanceMetricCriteriaOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for filtering
    /// </summary>
    public enum PerformanceMetricCriteriaOp
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
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
        /// <summary>
        /// 
        /// </summary>
        Le,
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
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerformanceMetricCriteriaOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerformanceMetricCriteriaOp value)
        {
            return value switch
            {
                PerformanceMetricCriteriaOp.Eq => "eq",
                PerformanceMetricCriteriaOp.Ge => "ge",
                PerformanceMetricCriteriaOp.Gt => "gt",
                PerformanceMetricCriteriaOp.Gte => "gte",
                PerformanceMetricCriteriaOp.Le => "le",
                PerformanceMetricCriteriaOp.Lt => "lt",
                PerformanceMetricCriteriaOp.Lte => "lte",
                PerformanceMetricCriteriaOp.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerformanceMetricCriteriaOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PerformanceMetricCriteriaOp.Eq,
                "ge" => PerformanceMetricCriteriaOp.Ge,
                "gt" => PerformanceMetricCriteriaOp.Gt,
                "gte" => PerformanceMetricCriteriaOp.Gte,
                "le" => PerformanceMetricCriteriaOp.Le,
                "lt" => PerformanceMetricCriteriaOp.Lt,
                "lte" => PerformanceMetricCriteriaOp.Lte,
                "ne" => PerformanceMetricCriteriaOp.Ne,
                _ => null,
            };
        }
    }
}