//HintName: G.Models.ExperimentRunSummaryPublicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentRunSummaryPublicStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passed")]
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentRunSummaryPublicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentRunSummaryPublicStatus value)
        {
            return value switch
            {
                ExperimentRunSummaryPublicStatus.Failed => "failed",
                ExperimentRunSummaryPublicStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentRunSummaryPublicStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExperimentRunSummaryPublicStatus.Failed,
                "passed" => ExperimentRunSummaryPublicStatus.Passed,
                _ => null,
            };
        }
    }
}