//HintName: G.Models.GetSettingsResponseAgentsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    public enum GetSettingsResponseAgentsLlmModel
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
    public static class GetSettingsResponseAgentsLlmModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsResponseAgentsLlmModel value)
        {
            return value switch
            {
                GetSettingsResponseAgentsLlmModel.Gpt41 => "gpt-4.1",
                GetSettingsResponseAgentsLlmModel.Gpt41Mini => "gpt-4.1-mini",
                GetSettingsResponseAgentsLlmModel.Gpt41Nano => "gpt-4.1-nano",
                GetSettingsResponseAgentsLlmModel.Gpt4oGlobal => "gpt-4o-global",
                GetSettingsResponseAgentsLlmModel.Gpt4oMini => "gpt-4o-mini",
                GetSettingsResponseAgentsLlmModel.Gpt5Mini => "gpt-5-mini",
                GetSettingsResponseAgentsLlmModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsResponseAgentsLlmModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => GetSettingsResponseAgentsLlmModel.Gpt41,
                "gpt-4.1-mini" => GetSettingsResponseAgentsLlmModel.Gpt41Mini,
                "gpt-4.1-nano" => GetSettingsResponseAgentsLlmModel.Gpt41Nano,
                "gpt-4o-global" => GetSettingsResponseAgentsLlmModel.Gpt4oGlobal,
                "gpt-4o-mini" => GetSettingsResponseAgentsLlmModel.Gpt4oMini,
                "gpt-5-mini" => GetSettingsResponseAgentsLlmModel.Gpt5Mini,
                "gpt-5-nano" => GetSettingsResponseAgentsLlmModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}