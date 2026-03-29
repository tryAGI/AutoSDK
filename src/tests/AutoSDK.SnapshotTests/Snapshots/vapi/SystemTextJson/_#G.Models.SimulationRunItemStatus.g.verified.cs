//HintName: G.Models.SimulationRunItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the current status of the run.
    /// </summary>
    public enum SimulationRunItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Evaluating,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
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
    public static class SimulationRunItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunItemStatus value)
        {
            return value switch
            {
                SimulationRunItemStatus.Canceled => "canceled",
                SimulationRunItemStatus.Evaluating => "evaluating",
                SimulationRunItemStatus.Failed => "failed",
                SimulationRunItemStatus.Passed => "passed",
                SimulationRunItemStatus.Queued => "queued",
                SimulationRunItemStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => SimulationRunItemStatus.Canceled,
                "evaluating" => SimulationRunItemStatus.Evaluating,
                "failed" => SimulationRunItemStatus.Failed,
                "passed" => SimulationRunItemStatus.Passed,
                "queued" => SimulationRunItemStatus.Queued,
                "running" => SimulationRunItemStatus.Running,
                _ => null,
            };
        }
    }
}