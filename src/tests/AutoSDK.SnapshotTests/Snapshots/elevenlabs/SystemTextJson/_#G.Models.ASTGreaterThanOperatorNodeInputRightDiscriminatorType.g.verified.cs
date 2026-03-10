//HintName: G.Models.ASTGreaterThanOperatorNodeInputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOperatorNodeInputRightDiscriminatorType
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
    public static class ASTGreaterThanOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOperatorNodeInputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}