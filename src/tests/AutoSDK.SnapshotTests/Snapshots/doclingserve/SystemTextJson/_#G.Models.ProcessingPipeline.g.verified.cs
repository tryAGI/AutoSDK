//HintName: G.Models.ProcessingPipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Available document processing pipeline types for different use cases.<br/>
    /// Each pipeline is optimized for specific document types and processing requirements.<br/>
    /// Select the appropriate pipeline based on your input format and desired output.<br/>
    /// Attributes:<br/>
    ///     LEGACY: Legacy pipeline for backward compatibility with older document processing workflows.<br/>
    ///     STANDARD: Standard pipeline for general document processing (PDF, DOCX, images, etc.) with layout analysis.<br/>
    ///     VLM: Vision-Language Model pipeline for advanced document understanding using multimodal AI models.<br/>
    ///     ASR: Automatic Speech Recognition pipeline for audio and video transcription to text.
    /// </summary>
    public enum ProcessingPipeline
    {
        /// <summary>
        /// 
        /// </summary>
        Asr,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Vlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingPipelineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingPipeline value)
        {
            return value switch
            {
                ProcessingPipeline.Asr => "asr",
                ProcessingPipeline.Legacy => "legacy",
                ProcessingPipeline.Standard => "standard",
                ProcessingPipeline.Vlm => "vlm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingPipeline? ToEnum(string value)
        {
            return value switch
            {
                "asr" => ProcessingPipeline.Asr,
                "legacy" => ProcessingPipeline.Legacy,
                "standard" => ProcessingPipeline.Standard,
                "vlm" => ProcessingPipeline.Vlm,
                _ => null,
            };
        }
    }
}