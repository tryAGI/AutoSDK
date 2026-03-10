//HintName: G.Models.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}