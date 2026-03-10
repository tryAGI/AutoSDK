//HintName: G.Models.ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTNotEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}