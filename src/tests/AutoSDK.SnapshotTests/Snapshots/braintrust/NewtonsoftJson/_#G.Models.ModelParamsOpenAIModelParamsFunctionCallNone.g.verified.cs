//HintName: G.Models.ModelParamsOpenAIModelParamsFunctionCallNone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelParamsOpenAIModelParamsFunctionCallNone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsFunctionCallNoneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsFunctionCallNone value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsFunctionCallNone.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsFunctionCallNone? ToEnum(string value)
        {
            return value switch
            {
                "none" => ModelParamsOpenAIModelParamsFunctionCallNone.None,
                _ => null,
            };
        }
    }
}