//HintName: G.Models.WorkflowToolResponseModelInputStepDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowToolResponseModelInputStepDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Edge,
        /// <summary>
        /// 
        /// </summary>
        MaxIterationsExceeded,
        /// <summary>
        /// 
        /// </summary>
        NestedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolResponseModelInputStepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolResponseModelInputStepDiscriminatorType value)
        {
            return value switch
            {
                WorkflowToolResponseModelInputStepDiscriminatorType.Edge => "edge",
                WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded => "max_iterations_exceeded",
                WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools => "nested_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolResponseModelInputStepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "edge" => WorkflowToolResponseModelInputStepDiscriminatorType.Edge,
                "max_iterations_exceeded" => WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded,
                "nested_tools" => WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools,
                _ => null,
            };
        }
    }
}