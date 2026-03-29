//HintName: G.Models.ModelParamsOpenAIModelParamsReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelParamsOpenAIModelParamsReasoningEffort
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelParamsOpenAIModelParamsReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelParamsOpenAIModelParamsReasoningEffort value)
        {
            return value switch
            {
                ModelParamsOpenAIModelParamsReasoningEffort.High => "high",
                ModelParamsOpenAIModelParamsReasoningEffort.Low => "low",
                ModelParamsOpenAIModelParamsReasoningEffort.Medium => "medium",
                ModelParamsOpenAIModelParamsReasoningEffort.Minimal => "minimal",
                ModelParamsOpenAIModelParamsReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelParamsOpenAIModelParamsReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelParamsOpenAIModelParamsReasoningEffort.High,
                "low" => ModelParamsOpenAIModelParamsReasoningEffort.Low,
                "medium" => ModelParamsOpenAIModelParamsReasoningEffort.Medium,
                "minimal" => ModelParamsOpenAIModelParamsReasoningEffort.Minimal,
                "none" => ModelParamsOpenAIModelParamsReasoningEffort.None,
                _ => null,
            };
        }
    }
}