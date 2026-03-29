//HintName: G.Models.WorkflowCustomModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`custom-llm`).
    /// </summary>
    public enum WorkflowCustomModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCustomModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCustomModelProvider value)
        {
            return value switch
            {
                WorkflowCustomModelProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCustomModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => WorkflowCustomModelProvider.CustomLlm,
                _ => null,
            };
        }
    }
}