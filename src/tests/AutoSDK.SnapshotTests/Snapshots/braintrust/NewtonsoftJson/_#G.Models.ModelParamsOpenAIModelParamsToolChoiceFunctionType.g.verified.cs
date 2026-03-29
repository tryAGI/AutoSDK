//HintName: G.Models.ModelParamsOpenAIModelParamsToolChoiceFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelParamsOpenAIModelParamsToolChoiceFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsToolChoiceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsToolChoiceFunctionType value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsToolChoiceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsToolChoiceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ModelParamsOpenAIModelParamsToolChoiceFunctionType.Function,
                _ => null,
            };
        }
    }
}