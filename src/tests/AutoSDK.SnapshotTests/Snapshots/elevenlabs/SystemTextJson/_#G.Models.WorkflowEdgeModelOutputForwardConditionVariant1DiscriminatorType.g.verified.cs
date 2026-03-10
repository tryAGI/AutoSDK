//HintName: G.Models.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType
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
    public static class WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Expression => "expression",
                WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Llm => "llm",
                WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Result => "result",
                WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Unconditional => "unconditional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "expression" => WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Expression,
                "llm" => WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Llm,
                "result" => WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Result,
                "unconditional" => WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Unconditional,
                _ => null,
            };
        }
    }
}