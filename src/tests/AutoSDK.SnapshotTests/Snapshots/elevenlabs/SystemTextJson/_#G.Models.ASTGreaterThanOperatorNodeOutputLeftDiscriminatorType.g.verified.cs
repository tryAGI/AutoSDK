//HintName: G.Models.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTGreaterThanOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}