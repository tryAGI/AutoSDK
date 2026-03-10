//HintName: G.Models.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTAndOperatorNodeInputChildrenItemDiscriminatorType
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
    public static class ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAndOperatorNodeInputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.Llm => "llm",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAndOperatorNodeInputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LteOperator,
                "neq_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}