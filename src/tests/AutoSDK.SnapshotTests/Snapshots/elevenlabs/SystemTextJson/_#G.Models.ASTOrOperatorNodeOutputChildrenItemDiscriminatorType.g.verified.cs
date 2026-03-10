//HintName: G.Models.ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTOrOperatorNodeOutputChildrenItemDiscriminatorType
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
    public static class ASTOrOperatorNodeOutputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTOrOperatorNodeOutputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.Llm => "llm",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTOrOperatorNodeOutputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator,
                "neq_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTOrOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}