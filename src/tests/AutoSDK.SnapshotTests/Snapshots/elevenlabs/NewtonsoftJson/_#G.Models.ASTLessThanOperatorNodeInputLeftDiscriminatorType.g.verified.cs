//HintName: G.Models.ASTLessThanOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTLessThanOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTLessThanOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}