//HintName: G.Models.ASTEqualsOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}