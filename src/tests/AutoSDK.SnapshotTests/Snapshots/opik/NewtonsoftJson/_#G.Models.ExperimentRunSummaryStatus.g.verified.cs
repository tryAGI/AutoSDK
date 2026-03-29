//HintName: G.Models.ExperimentRunSummaryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentRunSummaryStatus
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
    public static class ExperimentRunSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentRunSummaryStatus value)
        {
            return value switch
            {
                ExperimentRunSummaryStatus.Failed => "failed",
                ExperimentRunSummaryStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentRunSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExperimentRunSummaryStatus.Failed,
                "passed" => ExperimentRunSummaryStatus.Passed,
                _ => null,
            };
        }
    }
}