//HintName: G.Models.ASTLessThanOperatorNodeInputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTLessThanOperatorNodeInputRightDiscriminatorType
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
    public static class ASTLessThanOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTLessThanOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.LteOperator,
                "neq_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}