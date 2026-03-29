//HintName: G.Models.EquationOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EquationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="!=")]
        Neq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<=")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="==")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">=")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exists")]
        Exists,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_contains")]
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_exist")]
        NotExist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationOperator value)
        {
            return value switch
            {
                EquationOperator.Neq => "!=",
                EquationOperator.Lt => "<",
                EquationOperator.Lte => "<=",
                EquationOperator.Eq => "==",
                EquationOperator.Gt => ">",
                EquationOperator.Gte => ">=",
                EquationOperator.Contains => "contains",
                EquationOperator.Exists => "exists",
                EquationOperator.NotContains => "not_contains",
                EquationOperator.NotExist => "not_exist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EquationOperator.Neq,
                "<" => EquationOperator.Lt,
                "<=" => EquationOperator.Lte,
                "==" => EquationOperator.Eq,
                ">" => EquationOperator.Gt,
                ">=" => EquationOperator.Gte,
                "contains" => EquationOperator.Contains,
                "exists" => EquationOperator.Exists,
                "not_contains" => EquationOperator.NotContains,
                "not_exist" => EquationOperator.NotExist,
                _ => null,
            };
        }
    }
}