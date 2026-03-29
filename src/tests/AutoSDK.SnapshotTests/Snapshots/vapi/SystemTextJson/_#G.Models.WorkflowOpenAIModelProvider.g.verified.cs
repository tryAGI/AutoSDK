//HintName: G.Models.WorkflowOpenAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`openai`).
    /// </summary>
    public enum WorkflowOpenAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowOpenAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowOpenAIModelProvider value)
        {
            return value switch
            {
                WorkflowOpenAIModelProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowOpenAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => WorkflowOpenAIModelProvider.Openai,
                _ => null,
            };
        }
    }
}