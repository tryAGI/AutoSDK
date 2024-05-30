//HintName: G.Models.ListVectorStoreFilesFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListVectorStoreFilesFilter
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

    public static class ListVectorStoreFilesFilterExtensions
    {
        public static string ToValueString(this ListVectorStoreFilesFilter value)
        {
            return value switch
            {
                ListVectorStoreFilesFilter.InProgress => "in_progress",
                ListVectorStoreFilesFilter.Completed => "completed",
                ListVectorStoreFilesFilter.Failed => "failed",
                ListVectorStoreFilesFilter.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoreFilesFilter ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ListVectorStoreFilesFilter.InProgress,
                "completed" => ListVectorStoreFilesFilter.Completed,
                "failed" => ListVectorStoreFilesFilter.Failed,
                "cancelled" => ListVectorStoreFilesFilter.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoreFilesFilter ToEnum(int value)
        {
            return value switch
            {
                0 => ListVectorStoreFilesFilter.InProgress,
                1 => ListVectorStoreFilesFilter.Completed,
                2 => ListVectorStoreFilesFilter.Failed,
                3 => ListVectorStoreFilesFilter.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}