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
        STATUSCOMPLETED,
        /// <summary>
        /// Skipped.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_SKIPPED")]
        STATUSSKIPPED,
        /// <summary>
        /// Aborted with error.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_ERROR")]
        STATUSERROR,
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
                TraceStatus.STATUSCOMPLETED => "STATUS_COMPLETED",
                TraceStatus.STATUSSKIPPED => "STATUS_SKIPPED",
                TraceStatus.STATUSERROR => "STATUS_ERROR",
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
                "STATUS_COMPLETED" => TraceStatus.STATUSCOMPLETED,
                "STATUS_SKIPPED" => TraceStatus.STATUSSKIPPED,
                "STATUS_ERROR" => TraceStatus.STATUSERROR,
                _ => null,
            };
        }
    }
}