//HintName: G.Models.WorkflowToolResponseModelOutputStepDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowToolResponseModelOutputStepDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="edge")]
        Edge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_iterations_exceeded")]
        MaxIterationsExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nested_tools")]
        NestedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolResponseModelOutputStepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolResponseModelOutputStepDiscriminatorType value)
        {
            return value switch
            {
                WorkflowToolResponseModelOutputStepDiscriminatorType.Edge => "edge",
                WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded => "max_iterations_exceeded",
                WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools => "nested_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolResponseModelOutputStepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "edge" => WorkflowToolResponseModelOutputStepDiscriminatorType.Edge,
                "max_iterations_exceeded" => WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded,
                "nested_tools" => WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools,
                _ => null,
            };
        }
    }
}