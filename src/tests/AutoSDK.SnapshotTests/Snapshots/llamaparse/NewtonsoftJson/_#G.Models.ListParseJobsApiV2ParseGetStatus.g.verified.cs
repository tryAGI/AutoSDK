//HintName: G.Models.ListParseJobsApiV2ParseGetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListParseJobsApiV2ParseGetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListParseJobsApiV2ParseGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListParseJobsApiV2ParseGetStatus value)
        {
            return value switch
            {
                ListParseJobsApiV2ParseGetStatus.Cancelled => "CANCELLED",
                ListParseJobsApiV2ParseGetStatus.Completed => "COMPLETED",
                ListParseJobsApiV2ParseGetStatus.Failed => "FAILED",
                ListParseJobsApiV2ParseGetStatus.Pending => "PENDING",
                ListParseJobsApiV2ParseGetStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListParseJobsApiV2ParseGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListParseJobsApiV2ParseGetStatus.Cancelled,
                "COMPLETED" => ListParseJobsApiV2ParseGetStatus.Completed,
                "FAILED" => ListParseJobsApiV2ParseGetStatus.Failed,
                "PENDING" => ListParseJobsApiV2ParseGetStatus.Pending,
                "RUNNING" => ListParseJobsApiV2ParseGetStatus.Running,
                _ => null,
            };
        }
    }
}