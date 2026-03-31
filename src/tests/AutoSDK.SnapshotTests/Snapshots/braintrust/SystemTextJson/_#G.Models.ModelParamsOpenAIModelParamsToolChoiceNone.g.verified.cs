//HintName: G.Models.ModelParamsOpenAIModelParamsToolChoiceNone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelParamsOpenAIModelParamsToolChoiceNone
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsToolChoiceNoneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsToolChoiceNone value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsToolChoiceNone.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsToolChoiceNone? ToEnum(string value)
        {
            return value switch
            {
                "none" => ModelParamsOpenAIModelParamsToolChoiceNone.None,
                _ => null,
            };
        }
    }
}