//HintName: G.Models.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and_operator")]
        AndOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean_literal")]
        BooleanLiteral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_variable")]
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq_operator")]
        EqOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt_operator")]
        GtOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte_operator")]
        GteOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt_operator")]
        LtOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte_operator")]
        LteOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neq_operator")]
        NeqOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number_literal")]
        NumberLiteral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or_operator")]
        OrOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string_literal")]
        StringLiteral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}