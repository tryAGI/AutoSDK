//HintName: G.Models.InferenceFramework.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InferenceFramework
    {
        /// <summary>
        /// 
        /// </summary>
        Mlx,
        /// <summary>
        /// 
        /// </summary>
        Transformers,
        /// <summary>
        /// 
        /// </summary>
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