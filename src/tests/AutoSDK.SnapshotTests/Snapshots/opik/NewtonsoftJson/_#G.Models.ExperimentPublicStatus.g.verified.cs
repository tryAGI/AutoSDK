//HintName: G.Models.ExperimentPublicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentPublicStatus
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
    public static class ExperimentPublicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentPublicStatus value)
        {
            return value switch
            {
                ExperimentPublicStatus.Cancelled => "cancelled",
                ExperimentPublicStatus.Completed => "completed",
                ExperimentPublicStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentPublicStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExperimentPublicStatus.Cancelled,
                "completed" => ExperimentPublicStatus.Completed,
                "running" => ExperimentPublicStatus.Running,
                _ => null,
            };
        }
    }
}