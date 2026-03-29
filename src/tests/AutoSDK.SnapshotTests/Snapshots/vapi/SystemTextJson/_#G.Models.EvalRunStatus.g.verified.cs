//HintName: G.Models.EvalRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the eval run. When an eval run is created, the status is 'running'.<br/>
    /// When the eval run is completed, the status is 'ended'.<br/>
    /// Example: running
    /// </summary>
    public enum EvalRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunStatus value)
        {
            return value switch
            {
                EvalRunStatus.Ended => "ended",
                EvalRunStatus.Queued => "queued",
                EvalRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => EvalRunStatus.Ended,
                "queued" => EvalRunStatus.Queued,
                "running" => EvalRunStatus.Running,
                _ => null,
            };
        }
    }
}