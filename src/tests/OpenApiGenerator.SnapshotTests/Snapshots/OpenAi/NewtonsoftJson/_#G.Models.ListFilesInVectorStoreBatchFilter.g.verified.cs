//HintName: G.Models.ListFilesInVectorStoreBatchFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFilesInVectorStoreBatchFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    public static class ListFilesInVectorStoreBatchFilterExtensions
    {
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
        public static ListFilesInVectorStoreBatchFilter ToEnum(int value)
        {
            return value switch
            {
                0 => ListFilesInVectorStoreBatchFilter.InProgress,
                1 => ListFilesInVectorStoreBatchFilter.Completed,
                2 => ListFilesInVectorStoreBatchFilter.Failed,
                3 => ListFilesInVectorStoreBatchFilter.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}