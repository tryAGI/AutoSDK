//HintName: G.Models.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}