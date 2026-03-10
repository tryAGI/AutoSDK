//HintName: G.Models.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}