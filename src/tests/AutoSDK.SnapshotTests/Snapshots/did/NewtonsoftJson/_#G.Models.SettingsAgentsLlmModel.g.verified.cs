//HintName: G.Models.SettingsAgentsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SettingsAgentsLlmModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1")]
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini")]
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano")]
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-global")]
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini")]
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini")]
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano")]
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