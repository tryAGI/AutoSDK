//HintName: G.Models.InferenceJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InferenceJobType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CUSTOM_MODELS_INFERENCE")]
        CustomModelsInference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EMBEDDING_GENERATION")]
        EmbeddingGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INFERENCE")]
        Inference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TL_INFERENCE")]
        TlInference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRAINING")]
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InferenceJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InferenceJobType value)
        {
            return value switch
            {
                InferenceJobType.CustomModelsInference => "CUSTOM_MODELS_INFERENCE",
                InferenceJobType.EmbeddingGeneration => "EMBEDDING_GENERATION",
                InferenceJobType.Inference => "INFERENCE",
                InferenceJobType.TlInference => "TL_INFERENCE",
                InferenceJobType.Training => "TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InferenceJobType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_MODELS_INFERENCE" => InferenceJobType.CustomModelsInference,
                "EMBEDDING_GENERATION" => InferenceJobType.EmbeddingGeneration,
                "INFERENCE" => InferenceJobType.Inference,
                "TL_INFERENCE" => InferenceJobType.TlInference,
                "TRAINING" => InferenceJobType.Training,
                _ => null,
            };
        }
    }
}