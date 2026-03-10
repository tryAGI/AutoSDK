//HintName: G.Models.ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}