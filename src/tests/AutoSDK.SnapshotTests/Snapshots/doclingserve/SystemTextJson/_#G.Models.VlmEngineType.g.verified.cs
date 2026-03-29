//HintName: G.Models.VlmEngineType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of VLM inference engines available.
    /// </summary>
    public enum VlmEngineType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        ApiLmstudio,
        /// <summary>
        /// 
        /// </summary>
        ApiOllama,
        /// <summary>
        /// 
        /// </summary>
        ApiOpenai,
        /// <summary>
        /// 
        /// </summary>
        AutoInline,
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
    public static class VlmEngineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VlmEngineType value)
        {
            return value switch
            {
                VlmEngineType.Api => "api",
                VlmEngineType.ApiLmstudio => "api_lmstudio",
                VlmEngineType.ApiOllama => "api_ollama",
                VlmEngineType.ApiOpenai => "api_openai",
                VlmEngineType.AutoInline => "auto_inline",
                VlmEngineType.Mlx => "mlx",
                VlmEngineType.Transformers => "transformers",
                VlmEngineType.Vllm => "vllm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VlmEngineType? ToEnum(string value)
        {
            return value switch
            {
                "api" => VlmEngineType.Api,
                "api_lmstudio" => VlmEngineType.ApiLmstudio,
                "api_ollama" => VlmEngineType.ApiOllama,
                "api_openai" => VlmEngineType.ApiOpenai,
                "auto_inline" => VlmEngineType.AutoInline,
                "mlx" => VlmEngineType.Mlx,
                "transformers" => VlmEngineType.Transformers,
                "vllm" => VlmEngineType.Vllm,
                _ => null,
            };
        }
    }
}