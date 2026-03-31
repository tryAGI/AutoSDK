//HintName: G.Models.AgentUpdateDtoLlmDIdModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum AgentUpdateDtoLlmDIdModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateDtoLlmDIdModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmDIdModel value)
        {
            return value switch
            {
                AgentUpdateDtoLlmDIdModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmDIdModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => AgentUpdateDtoLlmDIdModel.GptOss120b,
                _ => null,
            };
        }
    }
}