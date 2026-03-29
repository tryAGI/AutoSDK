//HintName: G.Models.ModelParamsOpenAIModelParamsVerbosity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelParamsOpenAIModelParamsVerbosity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsVerbosity value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsVerbosity.High => "high",
                ModelParamsOpenAIModelParamsVerbosity.Low => "low",
                ModelParamsOpenAIModelParamsVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelParamsOpenAIModelParamsVerbosity.High,
                "low" => ModelParamsOpenAIModelParamsVerbosity.Low,
                "medium" => ModelParamsOpenAIModelParamsVerbosity.Medium,
                _ => null,
            };
        }
    }
}