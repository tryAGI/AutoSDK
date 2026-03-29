//HintName: G.Models.SimulationRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the run
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunStatus value)
        {
            return value switch
            {
                SimulationRunStatus.Ended => "ended",
                SimulationRunStatus.Queued => "queued",
                SimulationRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => SimulationRunStatus.Ended,
                "queued" => SimulationRunStatus.Queued,
                "running" => SimulationRunStatus.Running,
                _ => null,
            };
        }
    }
}