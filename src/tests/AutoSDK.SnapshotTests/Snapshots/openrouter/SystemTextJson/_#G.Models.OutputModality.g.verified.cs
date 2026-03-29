//HintName: G.Models.OutputModality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputModality value)
        {
            return value switch
            {
                OutputModality.Audio => "audio",
                OutputModality.Embeddings => "embeddings",
                OutputModality.Image => "image",
                OutputModality.Text => "text",
                OutputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => OutputModality.Audio,
                "embeddings" => OutputModality.Embeddings,
                "image" => OutputModality.Image,
                "text" => OutputModality.Text,
                "video" => OutputModality.Video,
                _ => null,
            };
        }
    }
}