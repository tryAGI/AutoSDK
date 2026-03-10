//HintName: G.Models.ASTEqualsOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTEqualsOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}