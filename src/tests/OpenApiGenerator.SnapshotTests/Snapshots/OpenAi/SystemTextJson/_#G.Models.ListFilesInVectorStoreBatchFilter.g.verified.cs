//HintName: G.Models.ListFilesInVectorStoreBatchFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFilesInVectorStoreBatchFilter
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFilesInVectorStoreBatchFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesInVectorStoreBatchFilter value)
        {
            return value switch
            {
                ListFilesInVectorStoreBatchFilter.InProgress => "in_progress",
                ListFilesInVectorStoreBatchFilter.Completed => "completed",
                ListFilesInVectorStoreBatchFilter.Failed => "failed",
                ListFilesInVectorStoreBatchFilter.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesInVectorStoreBatchFilter ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ListFilesInVectorStoreBatchFilter.InProgress,
                "completed" => ListFilesInVectorStoreBatchFilter.Completed,
                "failed" => ListFilesInVectorStoreBatchFilter.Failed,
                "cancelled" => ListFilesInVectorStoreBatchFilter.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}