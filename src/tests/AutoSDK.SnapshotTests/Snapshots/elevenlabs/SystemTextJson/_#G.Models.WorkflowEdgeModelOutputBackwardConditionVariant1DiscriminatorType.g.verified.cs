//HintName: G.Models.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType
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
    public static class WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Expression => "expression",
                WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Llm => "llm",
                WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Result => "result",
                WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Unconditional => "unconditional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "expression" => WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Expression,
                "llm" => WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Llm,
                "result" => WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Result,
                "unconditional" => WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Unconditional,
                _ => null,
            };
        }
    }
}