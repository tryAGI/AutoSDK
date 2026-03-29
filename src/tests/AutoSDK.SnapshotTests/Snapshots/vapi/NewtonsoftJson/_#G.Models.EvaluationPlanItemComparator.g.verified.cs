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
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluationPlanItemComparator
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
        [global::System.Runtime.Serialization.EnumMember(Value="neq")]
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