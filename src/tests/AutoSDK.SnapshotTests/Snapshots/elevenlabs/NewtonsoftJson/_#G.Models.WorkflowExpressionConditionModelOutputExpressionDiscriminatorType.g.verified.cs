//HintName: G.Models.WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowExpressionConditionModelOutputExpressionDiscriminatorType
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
    public static class WorkflowExpressionConditionModelOutputExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExpressionConditionModelOutputExpressionDiscriminatorType value)
        {
            return value switch
            {
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.AndOperator => "and_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.EqOperator => "eq_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.GtOperator => "gt_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.GteOperator => "gte_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.Llm => "llm",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.LtOperator => "lt_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.LteOperator => "lte_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.NeqOperator => "neq_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.NumberLiteral => "number_literal",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.OrOperator => "or_operator",
                WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExpressionConditionModelOutputExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.BooleanLiteral,
                "dynamic_variable" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.EqOperator,
                "gt_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.GtOperator,
                "gte_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.GteOperator,
                "llm" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.Llm,
                "lt_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.LtOperator,
                "lte_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.LteOperator,
                "neq_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.NeqOperator,
                "number_literal" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.OrOperator,
                "string_literal" => WorkflowExpressionConditionModelOutputExpressionDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}