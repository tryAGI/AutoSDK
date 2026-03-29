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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
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
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVectorStoreFilesFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVectorStoreFilesFilter value)
        {
            return value switch
            {
                ListVectorStoreFilesFilter.Cancelled => "cancelled",
                ListVectorStoreFilesFilter.Completed => "completed",
                ListVectorStoreFilesFilter.Failed => "failed",
                ListVectorStoreFilesFilter.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVectorStoreFilesFilter? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListVectorStoreFilesFilter.Cancelled,
                "completed" => ListVectorStoreFilesFilter.Completed,
                "failed" => ListVectorStoreFilesFilter.Failed,
                "in_progress" => ListVectorStoreFilesFilter.InProgress,
                _ => null,
            };
        }
    }
}