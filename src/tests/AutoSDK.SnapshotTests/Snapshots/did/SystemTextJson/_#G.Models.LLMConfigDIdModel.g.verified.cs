//HintName: G.Models.LLMConfigDIdModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum LLMConfigDIdModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigDIdModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigDIdModel value)
        {
            return value switch
            {
                LLMConfigDIdModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigDIdModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => LLMConfigDIdModel.GptOss120b,
                _ => null,
            };
        }
    }
}