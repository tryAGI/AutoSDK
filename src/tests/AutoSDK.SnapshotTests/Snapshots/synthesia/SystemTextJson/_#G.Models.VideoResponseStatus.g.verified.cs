//HintName: G.Models.VideoResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseStatus value)
        {
            return value switch
            {
                VideoResponseStatus.Approved => "approved",
                VideoResponseStatus.Complete => "complete",
                VideoResponseStatus.Deleted => "deleted",
                VideoResponseStatus.Error => "error",
                VideoResponseStatus.InProgress => "in_progress",
                VideoResponseStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => VideoResponseStatus.Approved,
                "complete" => VideoResponseStatus.Complete,
                "deleted" => VideoResponseStatus.Deleted,
                "error" => VideoResponseStatus.Error,
                "in_progress" => VideoResponseStatus.InProgress,
                "rejected" => VideoResponseStatus.Rejected,
                _ => null,
            };
        }
    }
}