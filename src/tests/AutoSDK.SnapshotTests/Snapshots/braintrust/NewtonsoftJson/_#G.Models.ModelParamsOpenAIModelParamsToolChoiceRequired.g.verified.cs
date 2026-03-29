//HintName: G.Models.ModelParamsOpenAIModelParamsToolChoiceRequired.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelParamsOpenAIModelParamsToolChoiceRequired
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required")]
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsToolChoiceRequiredExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsToolChoiceRequired value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsToolChoiceRequired.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsToolChoiceRequired? ToEnum(string value)
        {
            return value switch
            {
                "required" => ModelParamsOpenAIModelParamsToolChoiceRequired.Required,
                _ => null,
            };
        }
    }
}