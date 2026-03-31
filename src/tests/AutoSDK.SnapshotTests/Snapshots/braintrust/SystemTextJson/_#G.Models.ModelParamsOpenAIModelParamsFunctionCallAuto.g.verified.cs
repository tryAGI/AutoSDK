//HintName: G.Models.ModelParamsOpenAIModelParamsFunctionCallAuto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelParamsOpenAIModelParamsFunctionCallAuto
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsFunctionCallAutoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsFunctionCallAuto value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsFunctionCallAuto.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsFunctionCallAuto? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ModelParamsOpenAIModelParamsFunctionCallAuto.Auto,
                _ => null,
            };
        }
    }
}