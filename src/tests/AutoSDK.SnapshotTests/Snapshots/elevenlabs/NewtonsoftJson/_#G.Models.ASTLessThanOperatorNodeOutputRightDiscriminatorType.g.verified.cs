//HintName: G.Models.ASTLessThanOperatorNodeOutputRightDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTLessThanOperatorNodeOutputRightDiscriminatorType
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