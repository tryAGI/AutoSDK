//HintName: G.Models.UpdateResponseVariant1LlmDIdModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum UpdateResponseVariant1LlmDIdModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1LlmDIdModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmDIdModel value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmDIdModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmDIdModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => UpdateResponseVariant1LlmDIdModel.GptOss120b,
                _ => null,
            };
        }
    }
}