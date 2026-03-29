//HintName: G.Models.InferenceFramework.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InferenceFramework
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mlx")]
        Mlx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transformers")]
        Transformers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vllm")]
        Vllm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InferenceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InferenceFramework value)
        {
            return value switch
            {
                InferenceFramework.Mlx => "mlx",
                InferenceFramework.Transformers => "transformers",
                InferenceFramework.Vllm => "vllm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InferenceFramework? ToEnum(string value)
        {
            return value switch
            {
                "mlx" => InferenceFramework.Mlx,
                "transformers" => InferenceFramework.Transformers,
                "vllm" => InferenceFramework.Vllm,
                _ => null,
            };
        }
    }
}