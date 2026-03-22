//HintName: G.Models.TraceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status holds the the component execution outcome.<br/>
    ///  - STATUS_COMPLETED: Successfully completed.<br/>
    ///  - STATUS_SKIPPED: Skipped.<br/>
    ///  - STATUS_ERROR: Aborted with error.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceStatus
    {
        /// <summary>
        /// Successfully completed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_COMPLETED")]
        StatusCompleted,
        /// <summary>
        /// Aborted with error.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_ERROR")]
        StatusError,
        /// <summary>
        /// Skipped.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_SKIPPED")]
        StatusSkipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceStatus value)
        {
            return value switch
            {
                TraceStatus.StatusCompleted => "STATUS_COMPLETED",
                TraceStatus.StatusError => "STATUS_ERROR",
                TraceStatus.StatusSkipped => "STATUS_SKIPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceStatus? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_COMPLETED" => TraceStatus.StatusCompleted,
                "STATUS_ERROR" => TraceStatus.StatusError,
                "STATUS_SKIPPED" => TraceStatus.StatusSkipped,
                _ => null,
            };
        }
    }
}