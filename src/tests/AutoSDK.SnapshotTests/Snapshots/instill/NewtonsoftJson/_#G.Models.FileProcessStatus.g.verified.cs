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
    [global::System.Runtime.Serialization.DataContract]
    public enum FileProcessStatus
    {
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_NOTSTARTED")]
        NOTSTARTED,
        /// <summary>
        /// file is waiting for embedding process
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_WAITING")]
        WAITING,
        /// <summary>
        /// file is converting
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_CONVERTING")]
        CONVERTING,
        /// <summary>
        /// file is chunking
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_CHUNKING")]
        CHUNKING,
        /// <summary>
        /// file is embedding
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_EMBEDDING")]
        EMBEDDING,
        /// <summary>
        /// completed
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_COMPLETED")]
        COMPLETED,
        /// <summary>
        /// failed
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_FAILED")]
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