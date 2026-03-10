//HintName: G.Models.ASTEqualsOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}