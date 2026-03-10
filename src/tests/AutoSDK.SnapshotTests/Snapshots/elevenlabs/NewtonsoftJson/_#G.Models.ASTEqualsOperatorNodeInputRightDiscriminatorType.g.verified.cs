//HintName: G.Models.ASTEqualsOperatorNodeInputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTEqualsOperatorNodeInputRightDiscriminatorType
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
    public static class ASTEqualsOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}