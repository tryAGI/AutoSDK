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
        Notstarted,
        /// <summary>
        /// file is waiting for embedding process
        /// </summary>
        Waiting,
        /// <summary>
        /// file is converting
        /// </summary>
        Converting,
        /// <summary>
        /// file is chunking
        /// </summary>
        Chunking,
        /// <summary>
        /// file is embedding
        /// </summary>
        Embedding,
        /// <summary>
        /// completed
        /// </summary>
        Completed,
        /// <summary>
        /// failed
        /// </summary>
        Failed,
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
                FileProcessStatus.Notstarted => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.Waiting => "FILE_PROCESS_STATUS_WAITING",
                FileProcessStatus.Converting => "FILE_PROCESS_STATUS_CONVERTING",
                FileProcessStatus.Chunking => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.Embedding => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.Completed => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.Failed => "FILE_PROCESS_STATUS_FAILED",
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
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.Notstarted,
                "FILE_PROCESS_STATUS_WAITING" => FileProcessStatus.Waiting,
                "FILE_PROCESS_STATUS_CONVERTING" => FileProcessStatus.Converting,
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.Chunking,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.Embedding,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.Completed,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.Failed,
                _ => null,
            };
        }
    }
}