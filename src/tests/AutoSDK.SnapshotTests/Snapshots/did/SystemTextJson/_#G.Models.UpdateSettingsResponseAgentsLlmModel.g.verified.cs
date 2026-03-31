//HintName: G.Models.UpdateSettingsResponseAgentsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    public enum UpdateSettingsResponseAgentsLlmModel
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
    public static class UpdateSettingsResponseAgentsLlmModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSettingsResponseAgentsLlmModel value)
        {
            return value switch
            {
                UpdateSettingsResponseAgentsLlmModel.Gpt41 => "gpt-4.1",
                UpdateSettingsResponseAgentsLlmModel.Gpt41Mini => "gpt-4.1-mini",
                UpdateSettingsResponseAgentsLlmModel.Gpt41Nano => "gpt-4.1-nano",
                UpdateSettingsResponseAgentsLlmModel.Gpt4oGlobal => "gpt-4o-global",
                UpdateSettingsResponseAgentsLlmModel.Gpt4oMini => "gpt-4o-mini",
                UpdateSettingsResponseAgentsLlmModel.Gpt5Mini => "gpt-5-mini",
                UpdateSettingsResponseAgentsLlmModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSettingsResponseAgentsLlmModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => UpdateSettingsResponseAgentsLlmModel.Gpt41,
                "gpt-4.1-mini" => UpdateSettingsResponseAgentsLlmModel.Gpt41Mini,
                "gpt-4.1-nano" => UpdateSettingsResponseAgentsLlmModel.Gpt41Nano,
                "gpt-4o-global" => UpdateSettingsResponseAgentsLlmModel.Gpt4oGlobal,
                "gpt-4o-mini" => UpdateSettingsResponseAgentsLlmModel.Gpt4oMini,
                "gpt-5-mini" => UpdateSettingsResponseAgentsLlmModel.Gpt5Mini,
                "gpt-5-nano" => UpdateSettingsResponseAgentsLlmModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}