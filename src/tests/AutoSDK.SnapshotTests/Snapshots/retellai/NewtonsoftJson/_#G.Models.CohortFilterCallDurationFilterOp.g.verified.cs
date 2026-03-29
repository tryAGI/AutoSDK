//HintName: G.Models.CohortFilterCallDurationFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CohortFilterCallDurationFilterOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
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