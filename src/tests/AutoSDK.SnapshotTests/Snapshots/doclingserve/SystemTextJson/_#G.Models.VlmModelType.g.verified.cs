//HintName: G.Models.VlmModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VlmModelType
    {
        /// <summary>
        /// 
        /// </summary>
        DeepseekocrOllama,
        /// <summary>
        /// 
        /// </summary>
        GotOcr2,
        /// <summary>
        /// 
        /// </summary>
        GraniteDocling,
        /// <summary>
        /// 
        /// </summary>
        GraniteDoclingVllm,
        /// <summary>
        /// 
        /// </summary>
        GraniteVision,
        /// <summary>
        /// 
        /// </summary>
        GraniteVisionOllama,
        /// <summary>
        /// 
        /// </summary>
        GraniteVisionVllm,
        /// <summary>
        /// 
        /// </summary>
        Smoldocling,
        /// <summary>
        /// 
        /// </summary>
        SmoldoclingVllm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VlmModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VlmModelType value)
        {
            return value switch
            {
                VlmModelType.DeepseekocrOllama => "deepseekocr_ollama",
                VlmModelType.GotOcr2 => "got_ocr_2",
                VlmModelType.GraniteDocling => "granite_docling",
                VlmModelType.GraniteDoclingVllm => "granite_docling_vllm",
                VlmModelType.GraniteVision => "granite_vision",
                VlmModelType.GraniteVisionOllama => "granite_vision_ollama",
                VlmModelType.GraniteVisionVllm => "granite_vision_vllm",
                VlmModelType.Smoldocling => "smoldocling",
                VlmModelType.SmoldoclingVllm => "smoldocling_vllm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VlmModelType? ToEnum(string value)
        {
            return value switch
            {
                "deepseekocr_ollama" => VlmModelType.DeepseekocrOllama,
                "got_ocr_2" => VlmModelType.GotOcr2,
                "granite_docling" => VlmModelType.GraniteDocling,
                "granite_docling_vllm" => VlmModelType.GraniteDoclingVllm,
                "granite_vision" => VlmModelType.GraniteVision,
                "granite_vision_ollama" => VlmModelType.GraniteVisionOllama,
                "granite_vision_vllm" => VlmModelType.GraniteVisionVllm,
                "smoldocling" => VlmModelType.Smoldocling,
                "smoldocling_vllm" => VlmModelType.SmoldoclingVllm,
                _ => null,
            };
        }
    }
}