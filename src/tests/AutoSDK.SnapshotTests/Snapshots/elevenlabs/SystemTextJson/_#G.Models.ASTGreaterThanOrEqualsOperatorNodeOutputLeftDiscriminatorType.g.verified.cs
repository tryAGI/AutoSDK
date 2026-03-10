//HintName: G.Models.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}