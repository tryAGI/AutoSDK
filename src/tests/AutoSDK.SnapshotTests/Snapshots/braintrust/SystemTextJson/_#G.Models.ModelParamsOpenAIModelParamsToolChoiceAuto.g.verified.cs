//HintName: G.Models.ModelParamsOpenAIModelParamsToolChoiceAuto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelParamsOpenAIModelParamsToolChoiceAuto
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsToolChoiceAutoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsToolChoiceAuto value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsToolChoiceAuto.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsToolChoiceAuto? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ModelParamsOpenAIModelParamsToolChoiceAuto.Auto,
                _ => null,
            };
        }
    }
}