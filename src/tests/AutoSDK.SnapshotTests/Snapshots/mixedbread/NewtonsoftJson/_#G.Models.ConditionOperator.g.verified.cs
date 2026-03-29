//HintName: G.Models.ConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operator for a filter condition.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConditionOperator
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
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="like")]
        Like,
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
        [global::System.Runtime.Serialization.EnumMember(Value="not_eq")]
        NotEq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_in")]
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_like")]
        NotLike,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionOperator value)
        {
            return value switch
            {
                ConditionOperator.Eq => "eq",
                ConditionOperator.Gt => "gt",
                ConditionOperator.Gte => "gte",
                ConditionOperator.In => "in",
                ConditionOperator.Like => "like",
                ConditionOperator.Lt => "lt",
                ConditionOperator.Lte => "lte",
                ConditionOperator.NotEq => "not_eq",
                ConditionOperator.NotIn => "not_in",
                ConditionOperator.NotLike => "not_like",
                ConditionOperator.Regex => "regex",
                ConditionOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ConditionOperator.Eq,
                "gt" => ConditionOperator.Gt,
                "gte" => ConditionOperator.Gte,
                "in" => ConditionOperator.In,
                "like" => ConditionOperator.Like,
                "lt" => ConditionOperator.Lt,
                "lte" => ConditionOperator.Lte,
                "not_eq" => ConditionOperator.NotEq,
                "not_in" => ConditionOperator.NotIn,
                "not_like" => ConditionOperator.NotLike,
                "regex" => ConditionOperator.Regex,
                "starts_with" => ConditionOperator.StartsWith,
                _ => null,
            };
        }
    }
}