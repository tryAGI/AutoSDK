//HintName: G.Models.UploadStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the Upload.
    /// </summary>
    public enum UploadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadStatus value)
        {
            return value switch
            {
                UploadStatus.Cancelled => "cancelled",
                UploadStatus.Completed => "completed",
                UploadStatus.Expired => "expired",
                UploadStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => UploadStatus.Cancelled,
                "completed" => UploadStatus.Completed,
                "expired" => UploadStatus.Expired,
                "pending" => UploadStatus.Pending,
                _ => null,
            };
        }
    }
}