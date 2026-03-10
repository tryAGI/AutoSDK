//HintName: G.Models.ASTLessThanOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTLessThanOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}