//HintName: G.Models.RouterOpenRouterModelSupportedSamplingParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RouterOpenRouterModelSupportedSamplingParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frequency_penalty")]
        FrequencyPenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="presence_penalty")]
        PresencePenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repetition_penalty")]
        RepetitionPenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="seed")]
        Seed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="temperature")]
        Temperature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_k")]
        TopK,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_p")]
        TopP,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouterOpenRouterModelSupportedSamplingParameterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouterOpenRouterModelSupportedSamplingParameter value)
        {
            return value switch
            {
                RouterOpenRouterModelSupportedSamplingParameter.FrequencyPenalty => "frequency_penalty",
                RouterOpenRouterModelSupportedSamplingParameter.PresencePenalty => "presence_penalty",
                RouterOpenRouterModelSupportedSamplingParameter.RepetitionPenalty => "repetition_penalty",
                RouterOpenRouterModelSupportedSamplingParameter.Seed => "seed",
                RouterOpenRouterModelSupportedSamplingParameter.Stop => "stop",
                RouterOpenRouterModelSupportedSamplingParameter.Temperature => "temperature",
                RouterOpenRouterModelSupportedSamplingParameter.TopK => "top_k",
                RouterOpenRouterModelSupportedSamplingParameter.TopP => "top_p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouterOpenRouterModelSupportedSamplingParameter? ToEnum(string value)
        {
            return value switch
            {
                "frequency_penalty" => RouterOpenRouterModelSupportedSamplingParameter.FrequencyPenalty,
                "presence_penalty" => RouterOpenRouterModelSupportedSamplingParameter.PresencePenalty,
                "repetition_penalty" => RouterOpenRouterModelSupportedSamplingParameter.RepetitionPenalty,
                "seed" => RouterOpenRouterModelSupportedSamplingParameter.Seed,
                "stop" => RouterOpenRouterModelSupportedSamplingParameter.Stop,
                "temperature" => RouterOpenRouterModelSupportedSamplingParameter.Temperature,
                "top_k" => RouterOpenRouterModelSupportedSamplingParameter.TopK,
                "top_p" => RouterOpenRouterModelSupportedSamplingParameter.TopP,
                _ => null,
            };
        }
    }
}