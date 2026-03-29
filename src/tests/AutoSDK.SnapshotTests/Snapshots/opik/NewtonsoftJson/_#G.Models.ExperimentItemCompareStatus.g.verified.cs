//HintName: G.Models.ExperimentItemCompareStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentItemCompareStatus
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
    public static class ExperimentItemCompareStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemCompareStatus value)
        {
            return value switch
            {
                ExperimentItemCompareStatus.Failed => "failed",
                ExperimentItemCompareStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemCompareStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExperimentItemCompareStatus.Failed,
                "passed" => ExperimentItemCompareStatus.Passed,
                _ => null,
            };
        }
    }
}