﻿//HintName: G.Models.UploadStatus.g.cs

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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
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
                UploadStatus.Pending => "pending",
                UploadStatus.Completed => "completed",
                UploadStatus.Cancelled => "cancelled",
                UploadStatus.Expired => "expired",
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
                "pending" => UploadStatus.Pending,
                "completed" => UploadStatus.Completed,
                "cancelled" => UploadStatus.Cancelled,
                "expired" => UploadStatus.Expired,
                _ => null,
            };
        }
    }
}