//HintName: G.Models.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expression")]
        Expression,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="result")]
        Result,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unconditional")]
        Unconditional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Expression => "expression",
                WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Llm => "llm",
                WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Result => "result",
                WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Unconditional => "unconditional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "expression" => WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Expression,
                "llm" => WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Llm,
                "result" => WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Result,
                "unconditional" => WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Unconditional,
                _ => null,
            };
        }
    }
}