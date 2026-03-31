//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1LlmOpenAIModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1LlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmOpenAIModel value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41 => "gpt-4.1",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => ListMyAgentsResponseAgentVariant1LlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}