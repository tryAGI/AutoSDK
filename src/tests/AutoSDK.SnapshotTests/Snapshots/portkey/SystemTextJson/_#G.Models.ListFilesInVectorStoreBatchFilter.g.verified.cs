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
        Cancelled,
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
        InProgress,
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
                ListFilesInVectorStoreBatchFilter.Cancelled => "cancelled",
                ListFilesInVectorStoreBatchFilter.Completed => "completed",
                ListFilesInVectorStoreBatchFilter.Failed => "failed",
                ListFilesInVectorStoreBatchFilter.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesInVectorStoreBatchFilter? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListFilesInVectorStoreBatchFilter.Cancelled,
                "completed" => ListFilesInVectorStoreBatchFilter.Completed,
                "failed" => ListFilesInVectorStoreBatchFilter.Failed,
                "in_progress" => ListFilesInVectorStoreBatchFilter.InProgress,
                _ => null,
            };
        }
    }
}