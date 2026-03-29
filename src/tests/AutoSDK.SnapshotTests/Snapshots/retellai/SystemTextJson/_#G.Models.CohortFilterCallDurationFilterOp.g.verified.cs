//HintName: G.Models.CohortFilterCallDurationFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CohortFilterCallDurationFilterOp
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
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortFilterCallDurationFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortFilterCallDurationFilterOp value)
        {
            return value switch
            {
                CohortFilterCallDurationFilterOp.Eq => "eq",
                CohortFilterCallDurationFilterOp.Gt => "gt",
                CohortFilterCallDurationFilterOp.Gte => "gte",
                CohortFilterCallDurationFilterOp.Lt => "lt",
                CohortFilterCallDurationFilterOp.Lte => "lte",
                CohortFilterCallDurationFilterOp.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortFilterCallDurationFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CohortFilterCallDurationFilterOp.Eq,
                "gt" => CohortFilterCallDurationFilterOp.Gt,
                "gte" => CohortFilterCallDurationFilterOp.Gte,
                "lt" => CohortFilterCallDurationFilterOp.Lt,
                "lte" => CohortFilterCallDurationFilterOp.Lte,
                "ne" => CohortFilterCallDurationFilterOp.Ne,
                _ => null,
            };
        }
    }
}