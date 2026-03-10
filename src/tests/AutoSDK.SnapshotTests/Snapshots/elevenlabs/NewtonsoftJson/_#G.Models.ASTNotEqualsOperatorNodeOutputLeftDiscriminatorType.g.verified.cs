//HintName: G.Models.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}