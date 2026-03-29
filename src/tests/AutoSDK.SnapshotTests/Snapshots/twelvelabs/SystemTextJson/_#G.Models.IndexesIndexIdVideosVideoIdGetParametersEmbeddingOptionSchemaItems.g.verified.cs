//HintName: G.Models.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        Visual,
        /// <summary>
        /// 
        /// </summary>
        VisualText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems value)
        {
            return value switch
            {
                IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Audio => "audio",
                IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Transcription => "transcription",
                IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Visual => "visual",
                IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.VisualText => "visual-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Audio,
                "transcription" => IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Transcription,
                "visual" => IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.Visual,
                "visual-text" => IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems.VisualText,
                _ => null,
            };
        }
    }
}