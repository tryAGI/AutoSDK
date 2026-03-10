//HintName: G.Models.ASTLessThanOperatorNodeOutputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}