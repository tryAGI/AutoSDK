//HintName: G.Models.ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTAndOperatorNodeOutputChildrenItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and_operator")]
        AndOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean_literal")]
        BooleanLiteral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_variable")]
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq_operator")]
        EqOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt_operator")]
        GtOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte_operator")]
        GteOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt_operator")]
        LtOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte_operator")]
        LteOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neq_operator")]
        NeqOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number_literal")]
        NumberLiteral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or_operator")]
        OrOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string_literal")]
        StringLiteral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAndOperatorNodeOutputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.Llm => "llm",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAndOperatorNodeOutputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator,
                "neq_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}