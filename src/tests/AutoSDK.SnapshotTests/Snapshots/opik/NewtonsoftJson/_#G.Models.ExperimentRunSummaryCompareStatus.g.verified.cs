//HintName: G.Models.ExperimentRunSummaryCompareStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentRunSummaryCompareStatus
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
    public static class ExperimentRunSummaryCompareStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentRunSummaryCompareStatus value)
        {
            return value switch
            {
                ExperimentRunSummaryCompareStatus.Failed => "failed",
                ExperimentRunSummaryCompareStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentRunSummaryCompareStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExperimentRunSummaryCompareStatus.Failed,
                "passed" => ExperimentRunSummaryCompareStatus.Passed,
                _ => null,
            };
        }
    }
}