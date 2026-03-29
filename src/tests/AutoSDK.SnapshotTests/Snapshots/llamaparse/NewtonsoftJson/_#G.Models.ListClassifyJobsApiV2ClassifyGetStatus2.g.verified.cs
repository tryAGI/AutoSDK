//HintName: G.Models.ListClassifyJobsApiV2ClassifyGetStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListClassifyJobsApiV2ClassifyGetStatus2
    {
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
    public static class ListClassifyJobsApiV2ClassifyGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListClassifyJobsApiV2ClassifyGetStatus2 value)
        {
            return value switch
            {
                ListClassifyJobsApiV2ClassifyGetStatus2.Completed => "COMPLETED",
                ListClassifyJobsApiV2ClassifyGetStatus2.Failed => "FAILED",
                ListClassifyJobsApiV2ClassifyGetStatus2.Pending => "PENDING",
                ListClassifyJobsApiV2ClassifyGetStatus2.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListClassifyJobsApiV2ClassifyGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ListClassifyJobsApiV2ClassifyGetStatus2.Completed,
                "FAILED" => ListClassifyJobsApiV2ClassifyGetStatus2.Failed,
                "PENDING" => ListClassifyJobsApiV2ClassifyGetStatus2.Pending,
                "RUNNING" => ListClassifyJobsApiV2ClassifyGetStatus2.Running,
                _ => null,
            };
        }
    }
}