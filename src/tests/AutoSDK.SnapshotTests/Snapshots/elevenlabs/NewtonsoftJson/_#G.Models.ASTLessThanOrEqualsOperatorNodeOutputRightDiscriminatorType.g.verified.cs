//HintName: G.Models.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}