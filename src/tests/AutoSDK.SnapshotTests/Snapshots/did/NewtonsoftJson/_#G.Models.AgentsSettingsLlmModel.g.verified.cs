//HintName: G.Models.AgentsSettingsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSettingsLlmModel
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