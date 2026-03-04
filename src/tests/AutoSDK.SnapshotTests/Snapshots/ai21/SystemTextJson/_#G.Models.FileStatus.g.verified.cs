//HintName: G.Models.FileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum FileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DbRecordCreated,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        UploadFailed,
        /// <summary>
        /// 
        /// </summary>
        Processed,
        /// <summary>
        /// 
        /// </summary>
        ProcessingFailed,
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
                FileStatus.Uploaded => "UPLOADED",
                FileStatus.UploadFailed => "UPLOAD_FAILED",
                FileStatus.Processed => "PROCESSED",
                FileStatus.ProcessingFailed => "PROCESSING_FAILED",
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
                "UPLOADED" => FileStatus.Uploaded,
                "UPLOAD_FAILED" => FileStatus.UploadFailed,
                "PROCESSED" => FileStatus.Processed,
                "PROCESSING_FAILED" => FileStatus.ProcessingFailed,
                _ => null,
            };
        }
    }
}