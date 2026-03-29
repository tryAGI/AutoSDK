//HintName: G.Models.GetSettingsResponseAgentsLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI LLM models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSettingsResponseAgentsLlmModel
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