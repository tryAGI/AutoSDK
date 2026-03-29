//HintName: G.Models.ConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator you want to use to compare the parameter and value.
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
                ConditionOperator.Lt => "lt",
                ConditionOperator.Lte => "lte",
                ConditionOperator.Neq => "neq",
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
                "lt" => ConditionOperator.Lt,
                "lte" => ConditionOperator.Lte,
                "neq" => ConditionOperator.Neq,
                _ => null,
            };
        }
    }
}