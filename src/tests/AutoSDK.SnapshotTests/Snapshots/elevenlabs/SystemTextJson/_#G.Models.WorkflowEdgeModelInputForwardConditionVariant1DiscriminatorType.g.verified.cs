//HintName: G.Models.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Expression,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Result,
        /// <summary>
        /// 
        /// </summary>
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