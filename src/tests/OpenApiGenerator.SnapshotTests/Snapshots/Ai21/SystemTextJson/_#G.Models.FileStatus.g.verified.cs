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
        DBRECORDCREATED,
        /// <summary>
        /// 
        /// </summary>
        UPLOADED,
        /// <summary>
        /// 
        /// </summary>
        UPLOADFAILED,
        /// <summary>
        /// 
        /// </summary>
        PROCESSED,
        /// <summary>
        /// 
        /// </summary>
        PROCESSINGFAILED,
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
                FileStatus.DBRECORDCREATED => "DB_RECORD_CREATED",
                FileStatus.UPLOADED => "UPLOADED",
                FileStatus.UPLOADFAILED => "UPLOAD_FAILED",
                FileStatus.PROCESSED => "PROCESSED",
                FileStatus.PROCESSINGFAILED => "PROCESSING_FAILED",
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
                "DB_RECORD_CREATED" => FileStatus.DBRECORDCREATED,
                "UPLOADED" => FileStatus.UPLOADED,
                "UPLOAD_FAILED" => FileStatus.UPLOADFAILED,
                "PROCESSED" => FileStatus.PROCESSED,
                "PROCESSING_FAILED" => FileStatus.PROCESSINGFAILED,
                _ => null,
            };
        }
    }
}