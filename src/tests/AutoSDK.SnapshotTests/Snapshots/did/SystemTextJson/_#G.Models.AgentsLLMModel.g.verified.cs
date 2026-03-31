//HintName: G.Models.AgentsLLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    public enum AgentsLLMModel
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
    public static class AgentsLLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsLLMModel value)
        {
            return value switch
            {
                AgentsLLMModel.Gpt41 => "gpt-4.1",
                AgentsLLMModel.Gpt41Mini => "gpt-4.1-mini",
                AgentsLLMModel.Gpt41Nano => "gpt-4.1-nano",
                AgentsLLMModel.Gpt4oGlobal => "gpt-4o-global",
                AgentsLLMModel.Gpt4oMini => "gpt-4o-mini",
                AgentsLLMModel.Gpt5Mini => "gpt-5-mini",
                AgentsLLMModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsLLMModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => AgentsLLMModel.Gpt41,
                "gpt-4.1-mini" => AgentsLLMModel.Gpt41Mini,
                "gpt-4.1-nano" => AgentsLLMModel.Gpt41Nano,
                "gpt-4o-global" => AgentsLLMModel.Gpt4oGlobal,
                "gpt-4o-mini" => AgentsLLMModel.Gpt4oMini,
                "gpt-5-mini" => AgentsLLMModel.Gpt5Mini,
                "gpt-5-nano" => AgentsLLMModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}