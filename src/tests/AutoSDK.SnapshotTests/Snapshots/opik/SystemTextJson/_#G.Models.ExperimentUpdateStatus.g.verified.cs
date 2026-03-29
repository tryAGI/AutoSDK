//HintName: G.Models.ExperimentUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the experiment
    /// </summary>
    public enum ExperimentUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentUpdateStatus value)
        {
            return value switch
            {
                ExperimentUpdateStatus.Cancelled => "cancelled",
                ExperimentUpdateStatus.Completed => "completed",
                ExperimentUpdateStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExperimentUpdateStatus.Cancelled,
                "completed" => ExperimentUpdateStatus.Completed,
                "running" => ExperimentUpdateStatus.Running,
                _ => null,
            };
        }
    }
}