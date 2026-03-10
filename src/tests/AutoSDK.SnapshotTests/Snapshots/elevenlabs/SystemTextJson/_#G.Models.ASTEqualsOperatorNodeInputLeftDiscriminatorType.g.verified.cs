//HintName: G.Models.ASTEqualsOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTEqualsOperatorNodeInputLeftDiscriminatorType
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