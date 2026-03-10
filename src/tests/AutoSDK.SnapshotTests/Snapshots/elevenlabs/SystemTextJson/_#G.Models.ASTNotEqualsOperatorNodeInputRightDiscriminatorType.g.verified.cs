//HintName: G.Models.ASTNotEqualsOperatorNodeInputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNotEqualsOperatorNodeInputRightDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AndOperator,
        /// <summary>
        /// 
        /// </summary>
        BooleanLiteral,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        EqOperator,
        /// <summary>
        /// 
        /// </summary>
        GtOperator,
        /// <summary>
        /// 
        /// </summary>
        GteOperator,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        LtOperator,
        /// <summary>
        /// 
        /// </summary>
        LteOperator,
        /// <summary>
        /// 
        /// </summary>
        NeqOperator,
        /// <summary>
        /// 
        /// </summary>
        NumberLiteral,
        /// <summary>
        /// 
        /// </summary>
        OrOperator,
        /// <summary>
        /// 
        /// </summary>
        StringLiteral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}