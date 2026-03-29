//HintName: G.Models.CallDetailsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Final call status
    /// </summary>
    public enum CallDetailsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Busy,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
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
        NoAnswer,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallDetailsStatus value)
        {
            return value switch
            {
                CallDetailsStatus.Busy => "busy",
                CallDetailsStatus.Canceled => "canceled",
                CallDetailsStatus.Completed => "completed",
                CallDetailsStatus.Failed => "failed",
                CallDetailsStatus.NoAnswer => "no-answer",
                CallDetailsStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "busy" => CallDetailsStatus.Busy,
                "canceled" => CallDetailsStatus.Canceled,
                "completed" => CallDetailsStatus.Completed,
                "failed" => CallDetailsStatus.Failed,
                "no-answer" => CallDetailsStatus.NoAnswer,
                "unknown" => CallDetailsStatus.Unknown,
                _ => null,
            };
        }
    }
}