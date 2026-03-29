//HintName: G.Models.DIdLLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// D-ID LLM models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DIdLLMModel
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
    public static class DIdLLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIdLLMModel value)
        {
            return value switch
            {
                DIdLLMModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIdLLMModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => DIdLLMModel.GptOss120b,
                _ => null,
            };
        }
    }
}