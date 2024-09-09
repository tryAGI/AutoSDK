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
        public static ListFilesInVectorStoreBatchFilter? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ListFilesInVectorStoreBatchFilter.InProgress,
                "completed" => ListFilesInVectorStoreBatchFilter.Completed,
                "failed" => ListFilesInVectorStoreBatchFilter.Failed,
                "cancelled" => ListFilesInVectorStoreBatchFilter.Cancelled,
                _ => null,
            };
        }
    }
}