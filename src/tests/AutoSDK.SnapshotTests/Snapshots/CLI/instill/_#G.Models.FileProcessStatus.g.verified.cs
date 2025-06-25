//HintName: G.Models.FileProcessStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
    ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process<br/>
    ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting<br/>
    ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
    ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
    ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
    ///  - FILE_PROCESS_STATUS_FAILED: failed
    /// </summary>
    public enum FileProcessStatus
    {
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        NOTSTARTED,
        /// <summary>
        /// file is waiting for embedding process
        /// </summary>
        WAITING,
        /// <summary>
        /// file is converting
        /// </summary>
        CONVERTING,
        /// <summary>
        /// file is chunking
        /// </summary>
        CHUNKING,
        /// <summary>
        /// file is embedding
        /// </summary>
        EMBEDDING,
        /// <summary>
        /// completed
        /// </summary>
        COMPLETED,
        /// <summary>
        /// failed
        /// </summary>
        FAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileProcessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileProcessStatus value)
        {
            return value switch
            {
                FileProcessStatus.NOTSTARTED => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.WAITING => "FILE_PROCESS_STATUS_WAITING",
                FileProcessStatus.CONVERTING => "FILE_PROCESS_STATUS_CONVERTING",
                FileProcessStatus.CHUNKING => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.EMBEDDING => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.COMPLETED => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.FAILED => "FILE_PROCESS_STATUS_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileProcessStatus? ToEnum(string value)
        {
            return value switch
            {
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.NOTSTARTED,
                "FILE_PROCESS_STATUS_WAITING" => FileProcessStatus.WAITING,
                "FILE_PROCESS_STATUS_CONVERTING" => FileProcessStatus.CONVERTING,
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.CHUNKING,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.EMBEDDING,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.COMPLETED,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.FAILED,
                _ => null,
            };
        }
    }
}