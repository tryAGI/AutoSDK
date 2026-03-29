//HintName: G.Models.ExperimentWriteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentWriteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentWriteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentWriteStatus value)
        {
            return value switch
            {
                ExperimentWriteStatus.Cancelled => "cancelled",
                ExperimentWriteStatus.Completed => "completed",
                ExperimentWriteStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentWriteStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExperimentWriteStatus.Cancelled,
                "completed" => ExperimentWriteStatus.Completed,
                "running" => ExperimentWriteStatus.Running,
                _ => null,
            };
        }
    }
}