//HintName: G.Models.AgentResponseDtoVariant1LlmDIdModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1LlmDIdModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-oss-120b")]
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1LlmDIdModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmDIdModel value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmDIdModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmDIdModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => AgentResponseDtoVariant1LlmDIdModel.GptOss120b,
                _ => null,
            };
        }
    }
}