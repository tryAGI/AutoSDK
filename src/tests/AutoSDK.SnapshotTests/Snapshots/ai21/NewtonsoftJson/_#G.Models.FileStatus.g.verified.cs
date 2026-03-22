//HintName: G.Models.FileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DB_RECORD_CREATED")]
        DbRecordCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROCESSED")]
        Processed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROCESSING_FAILED")]
        ProcessingFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPLOADED")]
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPLOAD_FAILED")]
        UploadFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileStatus value)
        {
            return value switch
            {
                FileStatus.DbRecordCreated => "DB_RECORD_CREATED",
                FileStatus.Processed => "PROCESSED",
                FileStatus.ProcessingFailed => "PROCESSING_FAILED",
                FileStatus.Uploaded => "UPLOADED",
                FileStatus.UploadFailed => "UPLOAD_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileStatus? ToEnum(string value)
        {
            return value switch
            {
                "DB_RECORD_CREATED" => FileStatus.DbRecordCreated,
                "PROCESSED" => FileStatus.Processed,
                "PROCESSING_FAILED" => FileStatus.ProcessingFailed,
                "UPLOADED" => FileStatus.Uploaded,
                "UPLOAD_FAILED" => FileStatus.UploadFailed,
                _ => null,
            };
        }
    }
}