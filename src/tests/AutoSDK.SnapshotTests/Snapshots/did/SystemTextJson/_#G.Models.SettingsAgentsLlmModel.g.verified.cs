//HintName: G.Models.SettingsAgentsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    public enum SettingsAgentsLlmModel
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
    public static class SettingsAgentsLlmModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsAgentsLlmModel value)
        {
            return value switch
            {
                SettingsAgentsLlmModel.Gpt41 => "gpt-4.1",
                SettingsAgentsLlmModel.Gpt41Mini => "gpt-4.1-mini",
                SettingsAgentsLlmModel.Gpt41Nano => "gpt-4.1-nano",
                SettingsAgentsLlmModel.Gpt4oGlobal => "gpt-4o-global",
                SettingsAgentsLlmModel.Gpt4oMini => "gpt-4o-mini",
                SettingsAgentsLlmModel.Gpt5Mini => "gpt-5-mini",
                SettingsAgentsLlmModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsAgentsLlmModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => SettingsAgentsLlmModel.Gpt41,
                "gpt-4.1-mini" => SettingsAgentsLlmModel.Gpt41Mini,
                "gpt-4.1-nano" => SettingsAgentsLlmModel.Gpt41Nano,
                "gpt-4o-global" => SettingsAgentsLlmModel.Gpt4oGlobal,
                "gpt-4o-mini" => SettingsAgentsLlmModel.Gpt4oMini,
                "gpt-5-mini" => SettingsAgentsLlmModel.Gpt5Mini,
                "gpt-5-nano" => SettingsAgentsLlmModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}