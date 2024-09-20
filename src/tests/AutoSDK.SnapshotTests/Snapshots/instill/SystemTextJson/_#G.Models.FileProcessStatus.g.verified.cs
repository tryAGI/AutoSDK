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
        /// 
        /// </summary>
        FILEPROCESSSTATUSNOTSTARTED,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSWAITING,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSCONVERTING,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSCHUNKING,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSEMBEDDING,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSCOMPLETED,
        /// <summary>
        /// 
        /// </summary>
        FILEPROCESSSTATUSFAILED,
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
                FileProcessStatus.FILEPROCESSSTATUSNOTSTARTED => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.FILEPROCESSSTATUSWAITING => "FILE_PROCESS_STATUS_WAITING",
                FileProcessStatus.FILEPROCESSSTATUSCONVERTING => "FILE_PROCESS_STATUS_CONVERTING",
                FileProcessStatus.FILEPROCESSSTATUSCHUNKING => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.FILEPROCESSSTATUSEMBEDDING => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.FILEPROCESSSTATUSCOMPLETED => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.FILEPROCESSSTATUSFAILED => "FILE_PROCESS_STATUS_FAILED",
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
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.FILEPROCESSSTATUSNOTSTARTED,
                "FILE_PROCESS_STATUS_WAITING" => FileProcessStatus.FILEPROCESSSTATUSWAITING,
                "FILE_PROCESS_STATUS_CONVERTING" => FileProcessStatus.FILEPROCESSSTATUSCONVERTING,
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.FILEPROCESSSTATUSCHUNKING,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.FILEPROCESSSTATUSEMBEDDING,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.FILEPROCESSSTATUSCOMPLETED,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.FILEPROCESSSTATUSFAILED,
                _ => null,
            };
        }
    }
}