//HintName: G.Models.GetEvalRunsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEvalRunsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvalRunsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunsStatus value)
        {
            return value switch
            {
                GetEvalRunsStatus.Queued => "queued",
                GetEvalRunsStatus.InProgress => "in_progress",
                GetEvalRunsStatus.Completed => "completed",
                GetEvalRunsStatus.Canceled => "canceled",
                GetEvalRunsStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunsStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => GetEvalRunsStatus.Queued,
                "in_progress" => GetEvalRunsStatus.InProgress,
                "completed" => GetEvalRunsStatus.Completed,
                "canceled" => GetEvalRunsStatus.Canceled,
                "failed" => GetEvalRunsStatus.Failed,
                _ => null,
            };
        }
    }
}