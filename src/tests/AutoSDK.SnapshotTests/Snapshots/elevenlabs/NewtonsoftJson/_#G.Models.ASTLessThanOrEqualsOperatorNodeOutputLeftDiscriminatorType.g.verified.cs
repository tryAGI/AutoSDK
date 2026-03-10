//HintName: G.Models.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}