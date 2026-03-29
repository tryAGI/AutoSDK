//HintName: G.Models.FileProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Parsing,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileProcessingStatus value)
        {
            return value switch
            {
                FileProcessingStatus.Completed => "completed",
                FileProcessingStatus.Embedding => "embedding",
                FileProcessingStatus.Error => "error",
                FileProcessingStatus.Parsing => "parsing",
                FileProcessingStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FileProcessingStatus.Completed,
                "embedding" => FileProcessingStatus.Embedding,
                "error" => FileProcessingStatus.Error,
                "parsing" => FileProcessingStatus.Parsing,
                "pending" => FileProcessingStatus.Pending,
                _ => null,
            };
        }
    }
}