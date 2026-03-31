//HintName: G.Models.AgentLlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum AgentLlmOpenAIModel
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
    public static class AgentLlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmOpenAIModel value)
        {
            return value switch
            {
                AgentLlmOpenAIModel.Gpt41 => "gpt-4.1",
                AgentLlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                AgentLlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                AgentLlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                AgentLlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                AgentLlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                AgentLlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => AgentLlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => AgentLlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => AgentLlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => AgentLlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => AgentLlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => AgentLlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => AgentLlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}