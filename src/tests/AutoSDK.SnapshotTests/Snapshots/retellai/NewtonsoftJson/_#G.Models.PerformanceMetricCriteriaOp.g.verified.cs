//HintName: G.Models.PerformanceMetricCriteriaOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for filtering
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PerformanceMetricCriteriaOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="le")]
        Le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ne")]
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