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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_NOTSTARTED")]
        FILEPROCESSSTATUSNOTSTARTED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_WAITING")]
        FILEPROCESSSTATUSWAITING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_CONVERTING")]
        FILEPROCESSSTATUSCONVERTING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_CHUNKING")]
        FILEPROCESSSTATUSCHUNKING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_EMBEDDING")]
        FILEPROCESSSTATUSEMBEDDING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_COMPLETED")]
        FILEPROCESSSTATUSCOMPLETED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_PROCESS_STATUS_FAILED")]
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