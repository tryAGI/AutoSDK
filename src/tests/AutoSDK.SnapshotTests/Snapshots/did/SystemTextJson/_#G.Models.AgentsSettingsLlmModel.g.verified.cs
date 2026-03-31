//HintName: G.Models.AgentsSettingsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    public enum AgentsSettingsLlmModel
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
    public static class AgentsSettingsLlmModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSettingsLlmModel value)
        {
            return value switch
            {
                AgentsSettingsLlmModel.Gpt41 => "gpt-4.1",
                AgentsSettingsLlmModel.Gpt41Mini => "gpt-4.1-mini",
                AgentsSettingsLlmModel.Gpt41Nano => "gpt-4.1-nano",
                AgentsSettingsLlmModel.Gpt4oGlobal => "gpt-4o-global",
                AgentsSettingsLlmModel.Gpt4oMini => "gpt-4o-mini",
                AgentsSettingsLlmModel.Gpt5Mini => "gpt-5-mini",
                AgentsSettingsLlmModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSettingsLlmModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => AgentsSettingsLlmModel.Gpt41,
                "gpt-4.1-mini" => AgentsSettingsLlmModel.Gpt41Mini,
                "gpt-4.1-nano" => AgentsSettingsLlmModel.Gpt41Nano,
                "gpt-4o-global" => AgentsSettingsLlmModel.Gpt4oGlobal,
                "gpt-4o-mini" => AgentsSettingsLlmModel.Gpt4oMini,
                "gpt-5-mini" => AgentsSettingsLlmModel.Gpt5Mini,
                "gpt-5-nano" => AgentsSettingsLlmModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}