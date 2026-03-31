//HintName: G.Models.CreateResponseVariant1LlmDIdModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum CreateResponseVariant1LlmDIdModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant1LlmDIdModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmDIdModel value)
        {
            return value switch
            {
                CreateResponseVariant1LlmDIdModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmDIdModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => CreateResponseVariant1LlmDIdModel.GptOss120b,
                _ => null,
            };
        }
    }
}