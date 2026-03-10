//HintName: G.Models.ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASTGreaterThanOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "neq_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}