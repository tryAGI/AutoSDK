//HintName: G.Models.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType
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
    public static class WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Expression => "expression",
                WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Llm => "llm",
                WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Result => "result",
                WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Unconditional => "unconditional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "expression" => WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Expression,
                "llm" => WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Llm,
                "result" => WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Result,
                "unconditional" => WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Unconditional,
                _ => null,
            };
        }
    }
}