//HintName: G.Models.ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTNotEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}