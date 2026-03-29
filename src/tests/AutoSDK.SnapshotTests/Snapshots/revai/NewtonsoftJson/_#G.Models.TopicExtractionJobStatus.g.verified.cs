//HintName: G.Models.TopicExtractionJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicExtractionJobStatus
    {
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
    public static class TopicExtractionJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicExtractionJobStatus value)
        {
            return value switch
            {
                TopicExtractionJobStatus.Completed => "completed",
                TopicExtractionJobStatus.Failed => "failed",
                TopicExtractionJobStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicExtractionJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TopicExtractionJobStatus.Completed,
                "failed" => TopicExtractionJobStatus.Failed,
                "in_progress" => TopicExtractionJobStatus.InProgress,
                _ => null,
            };
        }
    }
}